namespace PersonaDemo;

public class Persona
{
    private string _nombre = "";
    private string _celular = "";
    private string _cedulaIdentidad = "";

    public Persona()
    {
        // notar el acceso a los atributos directamente, podria haberce usado las properties
        _nombre = "Sin nombre";
        _celular = "Sin celular";
        _cedulaIdentidad = "Sin cedula";
    }

    public Persona(string nombre, string celular, string cedulaIdentidad)
    {
        // notar el acceso a los atributos mediante las properties, podria haberce usado los atributos directamente
        Nombre = nombre;
        Celular = celular;
        CedulaIdentidad = cedulaIdentidad;
    }
    
    //getter y setters, en C# se llaman properties
    public string Nombre
    {
        get => _nombre;
        set => _nombre = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public string Celular
    {
        get => _celular;
        set => _celular = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public string CedulaIdentidad
    {
        get => _cedulaIdentidad;
        set => _cedulaIdentidad = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    // cómo hago para evitar el persona1.CedulaIdentidad == persona2.CedulaIdentidad ?
    protected bool Equals(Persona other)
    {
        return _cedulaIdentidad == other._cedulaIdentidad;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Persona)obj);
    }

    public override int GetHashCode()
    {
        return _cedulaIdentidad.GetHashCode();
    }

    public override string ToString()
    {
        return
            $"{nameof(_nombre)}: {_nombre}, {nameof(_celular)}: {_celular}, {nameof(_cedulaIdentidad)}: {_cedulaIdentidad}, {nameof(Nombre)}: {Nombre}, {nameof(Celular)}: {Celular}, {nameof(CedulaIdentidad)}: {CedulaIdentidad}";
    }
}