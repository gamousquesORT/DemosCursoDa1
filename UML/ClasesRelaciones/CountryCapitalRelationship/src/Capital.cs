namespace CountryCapitalRelationship;

public class Capital
{
    private Country? _country;

    public Capital(string cityName)
    {
        this.Name = cityName;
    }

    public string Name { get; }

    public string CountryName
    {
        get
        {
            if (_country != null) 
                return _country.Name; 
            throw new NullReferenceException("El país es nulo");
        }
    }

    public Country Country
    {
        get
        {
            if (_country != null) 
                return _country; 
            throw new NullReferenceException("El país es nulo");
        }
        set => _country = value;
    }
}