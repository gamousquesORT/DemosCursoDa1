namespace RecorrerPolimorficamente;

// Todas las personas en la universidad tienen un nombre y un numero de persona
public class PersonaUniversidad
{
    private string _nombreApellido;
    private int _numeroPersona;

    public PersonaUniversidad()
    {
        _nombreApellido = "sin asignar";
        _numeroPersona = 0;
    }

    public PersonaUniversidad(string nombreApellido, int numeroPersona)
    {
        this._nombreApellido = nombreApellido;
        this._numeroPersona = numeroPersona;
    }

    public String Nombre
    {
        get => _nombreApellido;
        set => _nombreApellido = value;
    }
    
    public int Numero
    {
        get => _numeroPersona;
        set => _numeroPersona = value;
    }
    
    // Probar el método sin la palabra clave virtual y ver el comportamiento
    public virtual string ObtenerDatos()
    {
        return string.Format($"Numero:{this._numeroPersona} - Nombre {this._nombreApellido} - Clase PersonaUniversidad: {this.GetType()}");
    }
    
    public override string ToString()
    {
        return string.Format($"Numero:{this._numeroPersona} Nombre {this._nombreApellido} - PersonaUniversidad: {this.GetType()}");
    }
}