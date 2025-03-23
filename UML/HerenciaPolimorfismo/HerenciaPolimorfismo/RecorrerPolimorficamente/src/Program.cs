using RecorrerPolimorficamente;


var listaPersonas = CreatePersonas();
ListPersonas(listaPersonas);

return;

List<PersonaUniversidad> CreatePersonas()
{
    List<PersonaUniversidad> personas = new List<PersonaUniversidad>();
    personas.Add(new Docente(DateTime.Now, "Juan Perez", 1001101));
    personas.Add(new Docente(DateTime.Now, "Maria Lopez", 1002234));
    personas.Add(new Alumno("Pedro Gomez", 2001876));
    personas.Add(new Alumno("Ana Rodriguez", 2002345));
    return personas;
}

void ListPersonas(List<PersonaUniversidad> listaPersonas)
{
    Console.WriteLine("Lista los datos de las PersonaUniversidad\n");
    foreach(PersonaUniversidad p in listaPersonas)
    {
        Console.WriteLine(p.ObtenerDatos());
    }

}


