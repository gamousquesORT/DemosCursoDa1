namespace RecorrerPolimorficamente;

public class Alumno : PersonaUniversidad
{
    private List<Carrera> _carreras;
    
    public Alumno()
    {
        _carreras = new List<Carrera>();
    }
    
    public Alumno(string nombreApellido, int numeroPersona): base(nombreApellido, numeroPersona)
    {
        _carreras = new List<Carrera>();
    }
    
    public override string ObtenerDatos()
    {
        return string.Format($"Numero:{this.Numero} - Nombre {this.Nombre} -> Clase Alumno: {this.GetType()}");
    }

    
    public override string ToString()
    {
        return string.Format($"Numero:{this.Numero} Nombre {this.Nombre}");
    }

    
}


public class Carrera
{
    
}