namespace Interfaz;

public class CalculadoraBasica : ICalculadora
{
    public double Multiplicar(double multiplicando, double multiplicador)
    {
        return multiplicando * multiplicador;
    }

    public double Dividir(double dividendo, double divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException();
        }
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
}