using System.Collections.Generic;

namespace DA2026.Tests
{
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
        private readonly List<Direccion> _direcciones = new List<Direccion>();

        public string Nombre { get; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
        
        public List<Direccion> Direcciones => _direcciones;

        public void AgregarDireccion(Direccion direccion)
        {
            if (!TieneDireccion(direccion))
            {
                _direcciones.Add(direccion);
            }
        }

        public void QuitarDireccion(Direccion direccion)
        {
            _direcciones.Remove(direccion);
        }

        public bool TieneDireccion(Direccion direccion)
        {
            return _direcciones.Contains(direccion);
        }

        public int CantidadDeDirecciones()
        {
            return _direcciones.Count;
        }
    }
}
