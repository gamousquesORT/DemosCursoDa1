namespace VehicleInheritance;

public class Motorcycle : Vehicle
{
    private bool _sidecar = false;
    
    public Motorcycle(string maker, string model, string id, bool hasSidecar) : base(maker, model, id)
    {
        Sidecar = _sidecar;
    }

    public Motorcycle()
    {

    }

    public bool Sidecar
    {
        get => _sidecar;
        set => _sidecar = value;
    } 
    
    public void Drive()
    {
        Console.WriteLine("The motorcycle is running");
    }
}