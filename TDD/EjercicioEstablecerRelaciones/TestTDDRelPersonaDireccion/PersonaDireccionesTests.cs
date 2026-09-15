using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DA2026.Tests
{
    // Objetivo pedagógico: el alumno debe hacer pasar estos tests escribiendo
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

            // Assert: la relación existe desde el inicio, sin elementos
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
            // Arrange: decisión de diseño típica a discutir con los alumnos
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

        [TestMethod]
        public void Direcciones_EsDeSoloLectura_DesdeAfueraDeLaPersona()
        {
            // Arrange: refuerza que la relación se modifica SOLO a través de
            // los métodos de Persona (encapsulamiento / ocultamiento de información),
            // no manipulando la colección expuesta directamente.
            var persona = new Persona("Juan Pérez");

            // Assert: Direcciones no debe ser una List<Direccion> ni similar
            // mutable públicamente (por ej. IEnumerable<Direccion> o IReadOnlyCollection<Direccion>)
            Assert.IsFalse(persona.Direcciones is System.Collections.Generic.List<Direccion>);
        }

        [TestMethod]
        public void Direccion_NoTieneReferenciaHaciaPersona()
        {
            // Assert de la DIRECCIONALIDAD: Direccion no conoce a su Persona.
            // Se verifica que la clase Direccion no expone ninguna propiedad
            // de tipo Persona (navegabilidad en un solo sentido).
            var propiedades = typeof(Direccion).GetProperties();

            var tieneReferenciaAPersona = propiedades
                .Any(p => p.PropertyType == typeof(Persona));

            Assert.IsFalse(tieneReferenciaAPersona,
                "Direccion no debería tener una propiedad de tipo Persona: la relación es unidireccional.");
        }
    }
}
