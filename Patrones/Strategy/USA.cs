namespace Strategy.Domain;

public class USA : IPais
{
    public string Codigo { get { return "us"; } }

    public int CalcularImpuestos(Compra unaC)
    {
        return (int)(unaC.Total * 0.07);
    }
}