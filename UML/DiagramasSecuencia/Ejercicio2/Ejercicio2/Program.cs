namespace Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        Persona pers = new Persona();
        pers.Numero = "1234";
        pers.NombreApellido = "Pedro SuApellido";
        pers.Calle = "Mi" +
                     "Calle";
        pers.NumeroCalle = "123";
        pers.ImprimirDatos();
    }
}