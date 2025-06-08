namespace Strategy.Domain;

public class CompraNoOCP
{
    // Muchos datos
    // ....

    public int Total { get; set; }

    public string Pais { get; set; }

    // Es un algoritmo que tienen distintas implementaciones
    // en este caso, una por pais.
    // Esta solucion no cumple con OCP!!
    public int CalcularImpuestos() {
        var impuestos = 0;

        if (Pais == "uy")
        {
            // Cada una de estas, es una implementacion particlar
            // del algoritmo.
        }
        else if (Pais == "ar") {
            // Quiero poder cambiar la implementacion que se usa
            // en tiempo de ejecucion.
        }

        return impuestos;
    }
}
