using RecorrerPolimorficamente;

Console.WriteLine("Llamada a ObtenerDatos para crear la lista de PersonasUniversidad\n");
foreach(PersonaUniversidad p in LoadData())
{
    Console.WriteLine(p.ObtenerDatos());
}

Console.WriteLine("\nLlamada al ToString de cada persona en la lista\n");
foreach(PersonaUniversidad p in LoadData())
{
    Console.WriteLine(p.ToString());
}

Console.WriteLine("\nPorque los nombres de las clases son diferentes en cada caso?");

//Metodo que carga la lista de personas
List<PersonaUniversidad> LoadData()
{
    List<PersonaUniversidad> personas = new List<PersonaUniversidad>();

    personas.Add(new Alumno("Juan Martinez", 123345));
    personas.Add(new Docente(DateTime.Today,"Pedro Algoritmo", 456123));
    personas.Add(new Alumno("Maria Castellanos", 789009));
    personas.Add(new Docente(DateTime.Today,"Ana María Datos", 101112));
    personas.Add(new PersonaUniversidad("Carlos Diseño", 131415));

    return personas;    
}   