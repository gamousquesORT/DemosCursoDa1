namespace PersonaEstudianteEj;

public class Persona
{
    private string _nombre;
    private string _cedula;

    public Persona()
    {
        _nombre = "Sin asignar";
        _cedula = "Sin asignar";
    }
    public Persona(string nombre, string cedula)
    {
        _nombre = nombre;
        _cedula = cedula;
    }

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public string Cedula
    {
        get { return _cedula; }
        set { _cedula = value; }
    }

    public override string ToString()
    {
        return string.Format($"CI:{this._cedula} Nombre {this._nombre}");
    }
    
}

public class Estudiante : Persona
{
    private int _numeroEstudiante;

    public Estudiante()
    {
        _numeroEstudiante = 0;
    }
    public Estudiante(string nombre, string cedula, int numeroEstudiante) : base(nombre, cedula)
    {
        _numeroEstudiante = numeroEstudiante;
    }
    
    public int NumeroEstudiante
    {
        get { return _numeroEstudiante; }
        set { _numeroEstudiante = value; }
    }

    public override string ToString()
    {
        return string.Format($"Numero:{this._numeroEstudiante} - {base.ToString()}");
    }
}