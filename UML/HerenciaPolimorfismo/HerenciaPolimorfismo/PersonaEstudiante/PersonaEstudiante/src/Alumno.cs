namespace RecorrerPolimorficamente;

public class Alumno : PersonaUniversidad
{
    private Carrera _carrera;
    
    public Alumno()
    {
        _carrera = new Carrera();
    }
    
    // Notar el base para invocar el constructor de la clase base
    public Alumno(string nombreApellido, int numeroPersona) : base(nombreApellido, numeroPersona)
    {
        this._carrera = new Carrera();
    }
    
    public Carrera Carrera =>  _carrera;
    
    public override string ToString()
    {
        return string.Format($"Numero:{this.Numero} - Nombre {this.Nombre} - Método ObtenerDatos de Alumno y Objeto de Clase: {this.GetType()}");
    }

    
}


public class Carrera
{
    
}