using System.Collections.Generic;
namespace PersonasDirecciones;

    // Implementación de referencia que hace pasar
    // PersonaDireccionesTests_OcultamientoInfo.cs
    //
    // Ocultamiento de información: la lista interna es privada y nunca
    // se devuelve ni se expone; toda interacción es por comportamiento
    // (TieneDireccion / CantidadDeDirecciones), no inspeccionando una
    // colección.

public class Direccion
{
    public string Calle { get; }
    public string Ciudad { get; }

    public Direccion(string calle, string ciudad)
    {
        Calle = calle;
        Ciudad = ciudad;
    }

    public override bool Equals(object obj)
    {
        return obj is Direccion otra
               && Calle == otra.Calle
               && Ciudad == otra.Ciudad;
    }

    public override int GetHashCode()
    {
        return (Calle, Ciudad).GetHashCode();
    }
}

public class Persona
{
    private readonly List<Direccion> direcciones = new List<Direccion>();

    public string Nombre { get; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    public void AgregarDireccion(Direccion direccion)
    {
        if (!TieneDireccion(direccion))
        {
            direcciones.Add(direccion);
        }
    }

    public void QuitarDireccion(Direccion direccion)
    {
        direcciones.Remove(direccion);
    }

    public bool TieneDireccion(Direccion direccion)
    {
        return direcciones.Contains(direccion);
    }

    public int CantidadDeDirecciones()
    {
        return direcciones.Count;
    }
}

