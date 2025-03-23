namespace ClaseAbstracta;

public class EmpleadoMensual : Empleado
{
    public decimal SalarioMensual { get; set; }
    
    public override void ImprimirDescripcion()
    {
        Console.WriteLine($"Número de Empleado: {NumeroEmpleado}");
    }
    public override void ImprimirNombre()
    {
        Console.WriteLine($"Nombre: {Nombre}");
    }
}