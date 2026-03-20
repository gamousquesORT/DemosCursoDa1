using RecorrerPolimorficamente;

Console.WriteLine("Llamada a ObtenerDatos y ToString sobre los elementos de la lista\n");
foreach(PersonaUniversidad p in LoadData())
{
    Console.WriteLine(p.ObtenerDatos());
    Console.WriteLine(p.ToString() + "\n");
}

Console.WriteLine("\nPorque los nombres de las clases son diferentes en cada caso?");

//Metodo que carga la lista de personas
List<PersonaUniversidad> LoadData()
{
    List<PersonaUniversidad> personas = new List<PersonaUniversidad>();

    personas.Add(new Alumno("Juan Alumno", 123345));
    personas.Add(new Docente(DateTime.Today,"Pedro Docente", 456123));
    personas.Add(new Alumno("Maria Alumna", 789009));
    personas.Add(new Docente(DateTime.Today,"Ana María Docente", 101112));
    personas.Add(new PersonaUniversidad("Carlos Persona", 131415));

    return personas;    
}   