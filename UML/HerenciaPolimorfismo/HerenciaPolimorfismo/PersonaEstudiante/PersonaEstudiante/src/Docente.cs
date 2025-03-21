namespace HerenciaPersona;

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
    
    public string ObtenerDatos()
    {
        return string.Format($"Numero:{this.Numero} - Nombre {this.Nombre} - Clase Docente: {this.GetType()}");
    }
    
    public override string ToString()
    {
        return string.Format($"Numero:{this.Numero} Nombre {this.Nombre} - Clase Docente: {this.GetType()}");
    }

}