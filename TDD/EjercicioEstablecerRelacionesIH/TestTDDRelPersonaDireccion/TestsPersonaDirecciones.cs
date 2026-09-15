using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonasDirecciones;
namespace TestTDDRelPersonaDireccion;

//
// UML esperado:
//   Persona "1" -----> "0..*" Direccion   (navegable solo desde Persona)
//
// Métodos que el alumno debe crear en Persona (mínimo):
//   void AgregarDireccion(Direccion direccion)
//   void QuitarDireccion(Direccion direccion)
//   bool TieneDireccion(Direccion direccion)
//   int CantidadDeDirecciones()
//
// Nada de "Direcciones { get; }" ni similar expuesto públicamente.

[TestClass]
public class PersonaDireccionesTests
{
    [TestMethod]
    public void Persona_AlCrearse_NoTieneDirecciones()
    {
        // Arrange
        var persona = new Persona("Juan Pérez");

        // Assert
        Assert.AreEqual(0, persona.CantidadDeDirecciones());
    }

    [TestMethod]
    public void AgregarDireccion_UnaVez_LaPersonaReconoceQueLaTiene()
    {
        // Arrange
        var persona = new Persona("Juan Pérez");
        var direccion = new Direccion("18 de Julio 1234", "Montevideo");

        // Act
        persona.AgregarDireccion(direccion);

        // Assert
        Assert.AreEqual(1, persona.CantidadDeDirecciones());
        Assert.IsTrue(persona.TieneDireccion(direccion));
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
        Assert.AreEqual(3, persona.CantidadDeDirecciones());
        Assert.IsTrue(persona.TieneDireccion(casa));
        Assert.IsTrue(persona.TieneDireccion(trabajo));
        Assert.IsTrue(persona.TieneDireccion(veraneo));
    }

    [TestMethod]
    public void TieneDireccion_ConDireccionNoAgregada_DevuelveFalso()
    {
        // Arrange
        var persona = new Persona("Juan Pérez");
        var casa = new Direccion("18 de Julio 1234", "Montevideo");
        var otra = new Direccion("Rambla 500", "Montevideo");
        persona.AgregarDireccion(casa);

        // Assert
        Assert.IsFalse(persona.TieneDireccion(otra));
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
        Assert.AreEqual(1, persona.CantidadDeDirecciones());
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
        Assert.AreEqual(1, persona.CantidadDeDirecciones());
        Assert.IsFalse(persona.TieneDireccion(casa));
        Assert.IsTrue(persona.TieneDireccion(trabajo));
    }

    [TestMethod]
    public void QuitarDireccion_QueNoEstaba_NoRompeYNoAfectaElConteo()
    {
        // Arrange
        var persona = new Persona("Juan Pérez");
        var casa = new Direccion("18 de Julio 1234", "Montevideo");
        var noAgregada = new Direccion("Rambla 500", "Montevideo");
        persona.AgregarDireccion(casa);

        // Act
        persona.QuitarDireccion(noAgregada);

        // Assert
        Assert.AreEqual(1, persona.CantidadDeDirecciones());
    }
}

