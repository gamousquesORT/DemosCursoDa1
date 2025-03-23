namespace Interfaz;

public class ScientificCalculator : ICalculadora
{
    public double Multiplicar(double multiplicando, double multiplicador)
    {
        return multiplicando * multiplicador;
    }

    public double Dividir(double dividendo, double divisor)
    {
        return dividendo / divisor;
    }
    
    public double Restar(double minuendo, double sustraendo)
    {
        return minuendo - sustraendo;   
    }
    
    public double Sumar(double sumando1, double sumando2)
    {
        return sumando1 + sumando2;
    }
    
    public double Potencia(double baseNum, double exponente)
    {
        return Math.Pow(baseNum, exponente);
    }
    
    public double RaizCuadrada(double radicando)
    {
        return Math.Sqrt(radicando);
    }
}