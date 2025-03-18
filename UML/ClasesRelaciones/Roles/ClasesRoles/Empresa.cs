namespace ClasesRoles;

public class Empresa
{
    private List<Empleado> _funcionarios;

    public Empresa()
    {
        _funcionarios = new List<Empleado>();
        NombreEmpresa= "Nombre de la empresa";
        RUT = "el RUT";
    }
    
    public string NombreEmpresa { get; set; }
    public string RUT  { get; set; }

    public void AgregarEmpleado(Empleado employee)
    {
        _funcionarios.Add(employee);
        employee.Empleador = this;
    }
}