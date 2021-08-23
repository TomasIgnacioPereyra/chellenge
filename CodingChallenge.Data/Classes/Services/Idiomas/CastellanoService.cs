using CodingChallenge.Data.Classes.Models;
using CodingChallenge.Data.Classes.Models.Idiomas;

namespace CodingChallenge.Data.Classes.Service.Idiomas
{
    public class CastellanoService : ITraductorFormas
    {

        public string TraducirForma(int cantidad, int tipo)
        {
            switch (tipo)
            {
                case (int)FormasEnum.Cuadrado:
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";

                case (int)FormasEnum.Circulo:
                    return cantidad == 1 ? "Círculo" : "Círculos";

                case (int)FormasEnum.Triangulo:
                    return cantidad == 1 ? "Triángulo" : "Triángulos";

                case (int)FormasEnum.Trapecio:
                    return cantidad == 1 ? "Trapecio" : "Trapecios";

                case (int)FormasEnum.Rectangulo:
                    return cantidad == 1 ? "Rectángulo" : "Rectángulos";
            }
            return string.Empty;
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(cantidad, tipo)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        public string GetListaVacia()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public string GetHeader()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public string GetTotalFormas(int total)
        {
            return total + " formas ";
        }

        public string GetTotalPerimetros(decimal total)
        {
            return "Perimetro " + total.ToString("#.##") + " ";
        }

        public string GetTotalArea(decimal total)
        {
            return "Area " + total.ToString("#.##") + " ";
        }
    }
}