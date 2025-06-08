namespace Strategy.Domain;
public class Uruguay : IPais
{
    public string Codigo { get { return "uy"; } }

    public int CalcularImpuestos(Compra unaC)
    {
        return (int)(unaC.Total * 0.22);
    }
}