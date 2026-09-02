using System;
using System.Collections.Generic;

List<Animal> animales = new()
{
    new Perro(),
    new Gato()
};

Console.WriteLine("Polimorfismo: mismo método, distinto comportamiento\n");

foreach (Animal animal in animales)
{
    Console.WriteLine($"Tipo real: {animal.GetType().Name}");
    animal.Respirar();
    animal.HacerSonido();
    Console.WriteLine();
}

Perro perro = new();
Animal otroAnimal = perro;

Console.WriteLine("Método específico de Perro:");
perro.Respirar();
perro.MoverCola();

//Ver porque no compila -
Console.WriteLine("Con variable Animal no se puede invocar MoverCola() directamente.");
//otroAnimal.MoverCola();
otroAnimal.Respirar();

abstract class Animal
{
    public void Respirar()
    {
        Console.WriteLine("Animal.Respirar() -> Todos los animales respiran.");
    }

    public virtual void HacerSonido()
    {
        Console.WriteLine("Animal hace un sonido.");
    }
}

class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Perro.HacerSonido() -> Guau!");
    }

    public void MoverCola()
    {
        Console.WriteLine("Perro.MoverCola() -> El perro mueve la cola.");
    }
}

class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Gato.HacerSonido() -> Miau!");
    }
}
