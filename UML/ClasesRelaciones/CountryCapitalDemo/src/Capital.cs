namespace ejemplosClase;

public class Capital
{
    private Country _country;

    public Capital(Country country, string cityName)
    {
        this.Name = cityName;
        this._country = country;
    }

    public string Name { get; }

    public string CountryName => _country.Name;

    public void SetCountry(Country country)
    {
        this._country = country;
    }
}