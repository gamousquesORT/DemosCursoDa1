namespace PersonaDemo;

public class Program
{
    public static void Main()
    {
        // Creamos dos personas con iguales valores (estado)
        Persona persona1 = new Persona();
        persona1.Nombre = "Juan";
        persona1.Celular = "099999999";
        persona1.CedulaIdentidad = "1234567-8";
        Console.WriteLine($"Nombre: {persona1.Nombre}");
        Console.WriteLine($"Celular: {persona1.Celular}");
        Console.WriteLine($"Cedula: {persona1.CedulaIdentidad} \n");

        Persona persona2 = new Persona("Juan", "099999999", "1234567-8");
        Console.WriteLine($"Nombre: {persona2.Nombre}");
        Console.WriteLine($"Celular: {persona2.Celular}");
        Console.WriteLine($"Cedula: {persona2.CedulaIdentidad}\n");

        // Si compararmos a las personas .... 
        Console.WriteLine("Comparando personas\n");
        Console.WriteLine($"persona1 == persona2: {persona1 == persona2}\n");
        if (persona1 == persona2)
        {
            Console.WriteLine("Da Verdadero porque son   ..... ?\n");
        }
        else
        {
            Console.WriteLine("Da Falso porque son  ..... ?\n");
        }

        Console.ReadKey();
        
        Console.WriteLine($"persona1.CedulaIdentidad == persona2.CedulaIdentidad: {persona1.CedulaIdentidad == persona2.CedulaIdentidad}\n");
        if (persona1.CedulaIdentidad == persona2.CedulaIdentidad)
        {
            Console.WriteLine("Tienen la misma cedula, son la misma persona, pero son distintos objetos\n");
        }
        else
        {
            Console.WriteLine("No tienen la misma cedula, son dos personas distintas y distintos objetos \n");
        }

        Console.ReadKey();
        // Creamos una nueva persona 
        Console.WriteLine("Creando persona3 y asignando persona1 = persona3;\n");
        Persona persona3 = new Persona() { Nombre = "Maria", Celular = "099999991", CedulaIdentidad = "1234567-5" };

        Console.WriteLine($"Nombre: {persona3.Nombre}, Celular: {persona3.Celular}, Cédula: {persona3.CedulaIdentidad}" + "\n");
        
        // Luego de esta asignación, que pasa?
        persona1 = persona3;
        
        Console.WriteLine($"persona1 == persona3: {persona1 == persona3}\n");
        if (persona1 == persona3)
        {
            Console.WriteLine("Da Verdadero porque son ....\n");
        }
        else
        {
            Console.WriteLine("Da Falso porque son ......\n");
        }
    }
}



