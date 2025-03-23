namespace VehicleInheritance;

public class Car : Vehicle
{
    private int _doors;
    
    public Car(string maker, string model, string id,  int doors) : base(maker, model, id)
    {
        Doors = doors;
    }

    public Car()
    {
        Doors = 2;
    }

    public int Doors
    {
        get => _doors;
        set => _doors = value;
    }
    
    public void Drive()
    {
        Console.WriteLine("The car is running");
    }
}