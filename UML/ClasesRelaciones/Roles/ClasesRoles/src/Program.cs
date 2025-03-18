
using ClasesRoles;

var empresa = new Empresa() { RUT = "0-2345", NombreEmpresa = "DA1 Enterprises" };

// al agregar el Empleado se establece la relacion unidireccional Empresa -----> Empleado
empresa.AgregarEmpleado(new Empleado(empresa) { CI = "5234567-1", Apellido = "Pasos",Nombre = "María"});
empresa.AgregarEmpleado(new Empleado(empresa) { CI = "4345634-1", Apellido = "Martin",Nombre = "Pepe"});

//listar los datos de los empleados 

Console.WriteLine("Listar Empleados");
foreach (var e in empresa.ListarEmpleados())
{
    Console.WriteLine($"Empleado {e.Nombre}, {e.Apellido}, CI: {e.CI}");
}