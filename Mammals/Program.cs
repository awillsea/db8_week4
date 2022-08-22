
Dog first = new Dog() { Name = "Fido", HairColor = "Black", BarkVolume = 8, LegCount = 4 };
//Console.WriteLine(first);
Dog second = new Dog() { Name = "Nellie", HairColor = "Yellow", BarkVolume = 5, LegCount = 4 };
Orangutan third = new Orangutan() { Name = "Fred",HairColor = "Orange", LegCount = 2, ThumbLength = 3 };
//Console.WriteLine(third);

List<Mammal> pets = new List<Mammal>();
pets.Add(first);
pets.Add(second);
pets.Add(third);

foreach (Mammal pet in pets)
{
    Console.WriteLine(pet);
}


Console.WriteLine();
Console.WriteLine("Test Method!");
Test(third);
static void Test(Mammal pet)
{
    string data = pet.ToString();
    Console.WriteLine(data);
}





class Mammal
{
    public string Name;
    public string HairColor; 
    public int LegCount;

    public void Walk()
    {
        Console.WriteLine("I am walking.");
    }


    // We are overriding what is called a "virtual" function.
    public override string ToString()
    {
        return "This is a Mammal";
    }

}

class Dog : Mammal
{
    public int BarkVolume;
    public override string ToString()
    {
        return $"Dog names:{Name}, hair {HairColor}, {LegCount} legs, barks at {BarkVolume}";
    }
}

class Orangutan : Mammal
{
    public int ThumbLength;
    public override string ToString()
    {
        return $"Orangutan names:{Name}, hair {HairColor}, {LegCount} legs, thumb is {ThumbLength} inches.";

    }
}

