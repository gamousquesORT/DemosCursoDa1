namespace OrdenConstruccion;

public class Estudiante : Persona
{   
    private int _numeroEstudiante;
    
    public Estudiante()
    {
        _numeroEstudiante = 0;
    }

    public Estudiante(string nombre, string cedula, int numeroEstudiante) : base(cedula, nombre)
    {
        _numeroEstudiante = numeroEstudiante;
    }

    public int Numero => _numeroEstudiante;
    public override string ToString()
    {
        return string.Format($"Numero:{this._numeroEstudiante} - {base.ToString()}");
    }
}