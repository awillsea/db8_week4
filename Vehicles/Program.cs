Sedan myCar = new Sedan(4, "Blue", true, 4);
myCar.Drive();

RaceCar myracecar = new RaceCar(4, "Red", 400);
myracecar.Drive();

Vehicle something;
something = myracecar;
something.Drive();


class Vehicle
{
     public int WheelCount;
     public string Color;
    public Vehicle(int wheelCount, string color)
    {
        WheelCount = wheelCount;
        Color = color;
    }

    public virtual void Drive()
    {
        Console.WriteLine("I am driving");
    }

}

class Sedan : Vehicle  // Ignore the error about constructor parameters.
{
    public bool HasHatchBack;
    public int DoorCount;
    public Sedan(int sedanwheelcount, string sedancolor, bool hashatchback, int doorcount) : base(sedanwheelcount, sedancolor)
    {
        HasHatchBack = hashatchback;
        DoorCount = doorcount;
    }
    public override void Drive()
    {
        Console.WriteLine("I am driving the speed limit");
    }
}

class RaceCar : Vehicle
{
    public int EngineSize;
    public RaceCar(int racecarwheelecount, string racecarcolor, int enginesize) : base(racecarwheelecount, racecarcolor)
    {
        EngineSize = enginesize;
    }
    public override void Drive()
    {
        Console.WriteLine("If You ain't first, your Last!");
    }
}