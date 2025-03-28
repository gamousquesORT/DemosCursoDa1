namespace ClasesRoles;

public class Empleado
{
    private Empresa? _empleador; //atributo para implementar la relación

    public Empleado(Empresa empleador)
    {
        _empleador = empleador;
        Nombre = "Nombre del Empleado";
        Apellido = "Apellido del Empleado";
        CI = "";
    }
    
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string CI { get; set; }
    public Empresa Empleador
    {
        get => _empleador;
        set => _empleador = value;
    }
}