namespace CapitalCountryThisDelegationDemo;

public class Country
{
    private Capital _capital;
    public Country(string countryName, string capitalName)
    {
        Name = countryName;
        // Ateneción al parámetro this
        _capital = new Capital(this, capitalName);
    }

    public string Name { get; }

    public string CapitalName => _capital.Name;

}