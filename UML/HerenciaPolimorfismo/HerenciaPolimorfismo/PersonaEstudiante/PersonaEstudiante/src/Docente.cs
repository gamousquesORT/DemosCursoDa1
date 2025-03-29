namespace RecorrerPolimorficamente;

public class Docente : PersonaUniversidad
{
    private DateTime _fechaIngreso;
    
    public Docente()
    {
        _fechaIngreso = DateTime.Now;
    }
    
    public Docente(DateTime fechaIngreso, string nombreApellido, int numeroPersona) : base(nombreApellido, numeroPersona)
    {
        this._fechaIngreso = fechaIngreso;
    }
    
    public DateTime FechaIngreso
    {
        get => _fechaIngreso;
    }
    
    // Probar el método sin la palabra clave override y ver el comportamiento
    public override string ObtenerDatos()
    {
        return string.Format($"Numero:{this.Numero} - Nombre {this.Nombre} - Clase Docente: {this.GetType()}");
    }
    
    public override string ToString()
    {
        return string.Format($"Numero:{this.Numero} Nombre {this.Nombre} - Clase Docente: {this.GetType()}");
    }

}