using CountryCapitalRelationship;

// Mal ejemplo sobre cómo establecer relación entre objetos
var country = new Country("Uruguay");
var capital = new Capital("Montevideo");

try
{
    country.Capital = capital;
    capital.Country = country;

    Console.WriteLine($"Country: {country.Name}");
    Console.WriteLine($"Capital: {country.Capital.Name}");
} catch(NullReferenceException) {
    Console.WriteLine("Country or Capital is null");
}
