namespace Interfaz;

public interface ICalculadora
{
    public double Sumar(double sumando1, double sumando2);
    public double Multiplicar(double multiplicando, double multiplicador);
    public double Dividir(double dividendo, double divisor);
    public double Restar(double minuendo, double sustraendo);
}