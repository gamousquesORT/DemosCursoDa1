namespace ClasesRoles;

public class Empresa
{
    private List<Empleado> _funcionarios; //atributo para implementar la relación

    public Empresa()
    {
        _funcionarios = new List<Empleado>(); // es una releación de N
        NombreEmpresa= "Nombre de la empresa";
        RUT = "el RUT";
    }
    
    public string NombreEmpresa { get; set; }
    public string RUT  { get; set; }

    public void AgregarEmpleado(Empleado employee)
    {
        _funcionarios.Add(employee);
        
        // si se quiere que la relación sea unidireccional la siguiente línea no va
        employee.Empleador = this;
    }

    public IEnumerable<Empleado> ListarEmpleados()
    {
        return _funcionarios;
    }
}