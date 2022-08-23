List<Car> listofCars = new List<Car>();
Initialize(listofCars);


Console.WriteLine("==============Hello! Welcome!==============");
do
{
    PrintList(listofCars);
    Console.WriteLine();
    Console.WriteLine("Would you like to Add a car to the list?");
    AddtoList(listofCars);
    Console.WriteLine("Would you like to Buy a car?");
    Buy(listofCars);
    Console.WriteLine("Do you want to see the update list of cars for sale?");
    if(YesorNo()){
        PrintList(listofCars);
    }
    else
    {
        Console.WriteLine("no worries!!");
    };

} while (KeepGoing());
Console.WriteLine("Thanks for Playing!");


static void PrintList(List<Car> _listofcars)
{
    for (int index = 0; index < _listofcars.Count; index++)
    {
        Car item = _listofcars[index];
        Console.WriteLine($"{index + 1}: {item}");
        Console.WriteLine();
    }
}
static void Initialize(List<Car> _listofcars)
{
    _listofcars.Add(new Car("Ford", "Bronco", 2022, 50000m));
    _listofcars.Add(new Car("Kia", "Optima", 2020, 23390.00m));
    _listofcars.Add(new Car());
    _listofcars.Add(new UsedCar("Nissan", "Sentra", 2013, 7000.00m,98978));
    _listofcars.Add(new UsedCar("Chevrolet","Corvette Sting Ray", 2020, 95000.00m, 7298));
    _listofcars.Add(new UsedCar());

}
static bool YesorNo()
{
    bool outsideValue = false;
    Console.Write("Yes, or No? :  ");
    
    bool validinput = false;
    while (!validinput)
    {
        string userInput = Console.ReadLine().ToLower();
        if (userInput == "y")
        {
            validinput = true;
            return outsideValue = true;
        }
        else if (userInput == "n")
        {
            validinput = true;
            return outsideValue = false;
        }
        else
        {
            Console.WriteLine("Please make sure to hit Y or N.");

            validinput = false;
        }
    }
    return outsideValue;
}
static string New_Or_UsedMethod(List<Car> _listofcars)
{
    string NeworUsed = "";
  
    if (YesorNo())
    {
        Console.WriteLine("Would you like to add a New or Used Car to the list?");
        NeworUsed = Console.ReadLine().ToLower();
        bool validInput = false;

        while (!validInput)
        {
            if (NeworUsed == "new" || NeworUsed == "used")
            {
                validInput = true;
                return NeworUsed;
                
            }
            else
            {
                Console.WriteLine("Please Type New or Used.");
                validInput = false;
            }
        }
    }else
    {
        Console.WriteLine("No Worries! ");
    }
    

    return NeworUsed;

}
static void AddtoList(List<Car> _listofcar)
{
    string neworUse = New_Or_UsedMethod(new List<Car>());
    if(neworUse == "new")
    {
        Console.WriteLine("Please add the following: Make, Model Year, Price.");
        Console.Write("Make: ");
        string make = Console.ReadLine();
        Console.Write("Model: ");
        string model = Console.ReadLine();
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Price: ");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"Are you sure you want to add a New Car:{make},{model},{year},{price} to the List?:");
        if (YesorNo()) 
        {
            _listofcar.Add(new Car(make,model,year,price));
        }else
        {
            Console.WriteLine("Ok!");
        }
    }
    else if(neworUse == "used")
    {
        Console.WriteLine("Please add the following: Make, Model Year, Price, Mileage.");
        Console.Write("Make: ");
        string make = Console.ReadLine();
        Console.Write("Model: ");
        string model = Console.ReadLine();
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Price: ");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Mileage: ");
        double mileage = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"Are you sure you want to add a New Car:{make},{model},{year},{price},{mileage} to the List?:");
        if (YesorNo())
        {
            _listofcar.Add(new UsedCar(make, model, year, price, mileage));
        }
        else
        {
            Console.WriteLine("Ok!");
        }

    }
}
static bool IntRange(List<Car> _listofcars,int usernum)
{
        
        if (usernum < 0 || usernum > _listofcars.Count)
        {
            Console.WriteLine("Please Make sure to hit a number that is on the List.");
        return false;
        }else
        {
        Console.WriteLine($"Perfect! ");
        return true;
        }
        
}
static void Buy(List<Car> _listofcar)
{
    if (YesorNo())
    {
        PrintList(_listofcar);
        Console.WriteLine("Please Select the car number you would like to purchase");


        int UserSelection = int.Parse(Console.ReadLine());
        
       
        IntRange(_listofcar, UserSelection);
        Console.WriteLine(UserSelection);



        _listofcar.Remove(_listofcar[UserSelection - 1]);
       
    }
    else
    {
        Console.WriteLine("No Worries!");
    }
}
static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to go again? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
}

class Car
{
    public string Make = "Toyota";
    public string Model = "4Runner";
    public int Year = 2019;
    public decimal Price = 35955.00m;

    public Car(string make, string model, int year, decimal price)
    {
        Make = make;
        Model = model;
        Year = year;
        Price = price;
    }

    public Car()
    {
  
    }
    

    public override string ToString()
    {
        return $"Make: {Make}\nModel:{Model}\nYear:{Year}\nPrice:{Price}";
    }
}

class UsedCar : Car
{
    public double Mileage;

    public UsedCar()
    {
        Make = " Hyundai";
        Model = "Genesis";
        Year = 2016;
        Price = 25590.00m;
    }
    public UsedCar(string make, string model, int year, decimal price,double mileage) :base (make,model,year,price)
    {
        Mileage = mileage;
    }

    public override string ToString()
    {
        return $"Used Car:\nMake: {Make}\nModel:{Model}\nYear:{Year}\nPrice:{Price}\nMileage:{Mileage}";
    }
}