namespace ClaseAbstracta;

public class Persona
{
    private string _cedula;
    private string _nombre;

    public Persona()
    {
        _nombre = "Sin nombre";
        _cedula = "Sin cedula";
    }
    
    public Persona(string cedula, string nombre)
    {
        _nombre = nombre;
        _cedula = cedula;
    }
    
    public string Nombre => _nombre;
    public string Cedula => _cedula;

    public override string ToString()
    {
        return string.Format($"Cedula:{this._cedula} Nombre {this._nombre}");
    }
}