using Interfaz;
/*
 * Ejemplo que usa el uso e implementación de interfaz
 */

ICalculadora calculadora = new CalculadoraBasica();
Console.WriteLine("Suma: " + calculadora.Sumar(5, 3));
Console.WriteLine("Resta: " + calculadora.Restar(5, 3));

// probar con la calculadora científica
calculadora = new ScientificCalculator();
Console.WriteLine("Suma: " + calculadora.Sumar(5, 3));
Console.WriteLine("Resta: " + calculadora.Restar(5, 3));

// esto no compilaría
// Console.WriteLine("Potencia: " + calculadora).Potencia(2, 3));
