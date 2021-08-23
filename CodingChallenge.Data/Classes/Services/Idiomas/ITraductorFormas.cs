using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Models.Idiomas
{
    public interface ITraductorFormas
    {
        string TraducirForma(int cantidad, int tipo);
        string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo);
        string GetListaVacia();
        string GetTotalFormas(int total);
        string GetTotalPerimetros(decimal total);
        string GetTotalArea(decimal total);

        string GetHeader();
    }

}
