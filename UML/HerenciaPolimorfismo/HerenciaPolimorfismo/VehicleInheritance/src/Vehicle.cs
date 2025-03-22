namespace VehicleInheritance;

public class Vehicle
{
    private string? _maker;
    private string? _model;
    private string? _id;

    public Vehicle()
    {
    }
    public Vehicle(string? maker, string? model, string id)
    {
        Maker = maker;
        Model = model;
        Id = id;
    }
    public string? Maker
    {
        get => _maker;
        set => _maker = value;
    }

    public string? Model
    {
        get => _model;
        set => _model = value;
    }

    public string? Id
    {
        get => _id;
        set => _id = value;
    }
    
    public void Drive()
    {
        Console.WriteLine("<< The vehicle is running >>");
    }

    // Código Generado por el Rider
    protected bool Equals(Vehicle other)
    {
        return _id == other._id;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Vehicle)obj);
    }

    public override int GetHashCode()
    {
        return (_id != null ? _id.GetHashCode() : 0);
    }
}