namespace CountryCapitalRelationship;

public class Country
{
    private Capital? _capital;
    public Country(string countryName)
    {
        Name = countryName;
    }

    public Capital Capital
    {
        get
        {
            if (_capital != null) return _capital; else throw new NullReferenceException();
        }
        set => _capital = value;
    }

    public string Name { get; }

    public string CapitalName => Capital.Name ?? throw new NullReferenceException();
    
}