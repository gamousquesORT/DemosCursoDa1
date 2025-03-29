namespace RecorrerPolimorficamente;

public class Alumno : PersonaUniversidad
{
    private List<Carrera> _carreras;
    
    public Alumno()
    {
        _carreras = new List<Carrera>();
    }
    
    // Notar el base para invocar el constructor de la clase base
    public Alumno(string nombreApellido, int numeroPersona) : base(nombreApellido, numeroPersona)
    {
        this._carreras = new List<Carrera>();
    }
    
    public override string ToString()
    {
        return string.Format($"Numero:{this.Numero} Nombre {this.Nombre} - Clase Alumno: {this.GetType()}");
    }

    
}


public class Carrera
{
    
}