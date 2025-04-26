using System.Security.Cryptography.X509Certificates;

namespace ConditionalTofunct;

public class PlaceHolder
{
    public DateTime FechaExpiracion { get; set; } 
    public bool AprobadoParaConsumo { get; set; }
    public int IdInspector { get; set; }
    
    public bool IsComestible()
    {
        if (FechaExpiracion > DateTime.Now && AprobadoParaConsumo 
                    && AprobadoParaConsumo == true && IdInspector !=0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}