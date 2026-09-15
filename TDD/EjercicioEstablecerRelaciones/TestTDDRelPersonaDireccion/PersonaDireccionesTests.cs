using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DA2026.Tests
{
    // Objetivo: Hacer pasar estos tests escribiendo
    // las clases Persona y Direccion. La relación es DIRECCIONAL
    // (Persona conoce sus Direcciones; Direccion NO conoce a la Persona)
    // y de MULTIPLICIDAD MÚLTIPLE (una Persona tiene 0..* Direcciones).
    //
    // UML esperado:
    //   Persona "1" -----> "0..*" Direccion
    //   (flecha de navegabilidad solo desde Persona hacia Direccion)

    [TestClass]
    public class PersonaDireccionesTests
    {
        [TestMethod]
        public void Persona_AlCrearse_TieneColeccionDeDireccionesVacia()
        {
            // Arrange
            var persona = new Persona("Juan Pérez");

            // Assert
            Assert.IsNotNull(persona.Direcciones);
            Assert.AreEqual(0, persona.Direcciones.Count());
        }

        [TestMethod]
        public void AgregarDireccion_UnaVez_QuedaRegistradaEnLaPersona()
        {
            // Arrange
            var persona = new Persona("Juan Pérez");
            var direccion = new Direccion("18 de Julio 1234", "Montevideo");

            // Act
            persona.AgregarDireccion(direccion);

            // Assert
            Assert.AreEqual(1, persona.Direcciones.Count());
            Assert.IsTrue(persona.Direcciones.Contains(direccion));
        }

        [TestMethod]
        public void AgregarDireccion_Varias_SeAcumulanTodas()
        {
            // Arrange: multiplicidad múltiple -> una persona admite N direcciones
            var persona = new Persona("Juan Pérez");
            var casa = new Direccion("18 de Julio 1234", "Montevideo");
            var trabajo = new Direccion("Rambla 500", "Montevideo");
            var veraneo = new Direccion("Av. Roosevelt 100", "Punta del Este");

            // Act
            persona.AgregarDireccion(casa);
            persona.AgregarDireccion(trabajo);
            persona.AgregarDireccion(veraneo);

            // Assert
            Assert.AreEqual(3, persona.Direcciones.Count());
            CollectionAssert.Contains(persona.Direcciones.ToList(), casa);
            CollectionAssert.Contains(persona.Direcciones.ToList(), trabajo);
            CollectionAssert.Contains(persona.Direcciones.ToList(), veraneo);
        }

        [TestMethod]
        public void AgregarDireccion_MismaDireccionDosVeces_NoSeDuplica()
        {
            // Arrange
            var persona = new Persona("Juan Pérez");
            var casa = new Direccion("18 de Julio 1234", "Montevideo");

            // Act
            persona.AgregarDireccion(casa);
            persona.AgregarDireccion(casa);

            // Assert
            Assert.AreEqual(1, persona.Direcciones.Count());
        }

        [TestMethod]
        public void QuitarDireccion_DireccionExistente_LaElimina()
        {
            // Arrange
            var persona = new Persona("Juan Pérez");
            var casa = new Direccion("18 de Julio 1234", "Montevideo");
            var trabajo = new Direccion("Rambla 500", "Montevideo");
            persona.AgregarDireccion(casa);
            persona.AgregarDireccion(trabajo);

            // Act
            persona.QuitarDireccion(casa);

            // Assert
            Assert.AreEqual(1, persona.Direcciones.Count());
            Assert.IsFalse(persona.Direcciones.Contains(casa));
            Assert.IsTrue(persona.Direcciones.Contains(trabajo));
        }
        
    }
}
