using System;
using System.Collections.Generic;
using System.Linq;
using DA2026.Tests;

namespace ConsolaPersonaDirecciones
{
    internal class Program
    {
        private static readonly List<Persona> Personas = new();

        private static void Main()
        {
            MostrarMenu();
        }

        private static void EsperarContinuacion()
        {
            if (Console.IsInputRedirected)
            {
                Console.ReadLine();
                return;
            }

            Console.ReadKey();
        }

        private static void MostrarMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Gestion de Personas y Direcciones ===");
                Console.WriteLine("1. Agregar persona");
                Console.WriteLine("2. Listar personas");
                Console.WriteLine("3. Agregar direccion a una persona");
                Console.WriteLine("4. Quitar direccion de una persona");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");

                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarPersona();
                        break;
                    case "2":
                        ListarPersonas();
                        break;
                    case "3":
                        AgregarDireccionAUnaPersona();
                        break;
                    case "4":
                        QuitarDireccionAUnaPersona();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opcion invalida. Presione una tecla para continuar.");
                        EsperarContinuacion();
                        break;
                }
            }
        }

        private static void AgregarPersona()
        {
            Console.Write("Ingrese el nombre de la persona: ");
            var nombre = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacio.");
                EsperarContinuacion();
                return;
            }

            if (Personas.Any(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"La persona '{nombre}' ya existe.");
                EsperarContinuacion();
                return;
            }

            Personas.Add(new Persona(nombre.Trim()));
            Console.WriteLine($"Persona '{nombre.Trim()}' agregada.");
            EsperarContinuacion();
        }

        private static void ListarPersonas()
        {
            if (!Personas.Any())
            {
                Console.WriteLine("No hay personas registradas.");
            EsperarContinuacion();
                return;
            }

            foreach (var persona in Personas)
            {
                Console.WriteLine($"- {persona.Nombre}");
                if (!persona.Direcciones.Any())
                {
                    Console.WriteLine("  Sin direcciones");
                    continue;
                }

                foreach (var direccion in persona.Direcciones)
                {
                    Console.WriteLine($"  * {direccion.Calle}, {direccion.Ciudad}");
                }
            }

            Console.WriteLine("Presione una tecla para continuar.");
            EsperarContinuacion();
        }

        private static void AgregarDireccionAUnaPersona()
        {
            if (!Personas.Any())
            {
                Console.WriteLine("Primero debe agregar al menos una persona.");
                EsperarContinuacion();
                return;
            }

            Console.Write("Ingrese el nombre de la persona: ");
            var nombre = Console.ReadLine();
            var persona = Personas.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (persona is null)
            {
                Console.WriteLine($"No existe una persona con el nombre '{nombre}'.");
                EsperarContinuacion();
                return;
            }

            Console.Write("Ingrese la calle: ");
            var calle = Console.ReadLine();
            Console.Write("Ingrese la ciudad: ");
            var ciudad = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(calle) || string.IsNullOrWhiteSpace(ciudad))
            {
                Console.WriteLine("La calle y la ciudad no pueden estar vacias.");
                EsperarContinuacion();
                return;
            }

            var direccion = new Direccion(calle.Trim(), ciudad.Trim());
            persona.AgregarDireccion(direccion);
            Console.WriteLine("Direccion agregada correctamente.");
            EsperarContinuacion();
        }

        private static void QuitarDireccionAUnaPersona()
        {
            if (!Personas.Any())
            {
                Console.WriteLine("Primero debe agregar al menos una persona.");
                EsperarContinuacion();
                return;
            }

            Console.Write("Ingrese el nombre de la persona: ");
            var nombre = Console.ReadLine();
            var persona = Personas.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (persona is null)
            {
                Console.WriteLine($"No existe una persona con el nombre '{nombre}'.");
                EsperarContinuacion();
                return;
            }

            if (!persona.Direcciones.Any())
            {
                Console.WriteLine($"La persona '{persona.Nombre}' no tiene direcciones para quitar.");
                EsperarContinuacion();
                return;
            }

            Console.WriteLine("Direcciones actuales:");
            for (var i = 0; i < persona.Direcciones.Count; i++)
            {
                var direccion = persona.Direcciones[i];
                Console.WriteLine($"{i + 1}. {direccion.Calle}, {direccion.Ciudad}");
            }

            Console.Write("Seleccione el numero de direccion a quitar: ");
            var indiceTexto = Console.ReadLine();

            if (!int.TryParse(indiceTexto, out var indice) || indice < 1 || indice > persona.Direcciones.Count)
            {
                Console.WriteLine("Indice invalido.");
                EsperarContinuacion();
                return;
            }

            var direccionSeleccionada = persona.Direcciones[indice - 1];
            persona.QuitarDireccion(direccionSeleccionada);
            Console.WriteLine("Direccion eliminada correctamente.");
            EsperarContinuacion();
        }
    }
}
