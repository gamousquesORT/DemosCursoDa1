namespace Strategy.Domain;

public interface IPais {
    String Codigo { get; }

    int CalcularImpuestos(Compra unaC);
}