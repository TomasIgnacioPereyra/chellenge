using CodingChallenge.Data.Classes.Models;
using CodingChallenge.Data.Classes.Models.Idiomas;

namespace CodingChallenge.Data.Classes.Service.Idiomas
{
    public class PortuguesService : ITraductorFormas
    {
        public string TraducirForma(int cantidad,int tipo)
        {
            switch (tipo)
            {
                case (int)FormasEnum.Cuadrado:
                    return cantidad == 1 ? "Quadrado" : "Quadrados";

                case (int)FormasEnum.Circulo:
                    return cantidad == 1 ? "Círculo" : "Círculos";

                case (int)FormasEnum.TrianguloEquilatero:
                    return cantidad == 1 ? "Triângulo" : "Triângulos";

                case (int)FormasEnum.Trapecio:
                    return cantidad == 1 ? "Trapézio" : "Trapézio";

                case (int)FormasEnum.Rectangulo:
                    return cantidad == 1 ? "Retângulo" : "Retângulos";
            }
            return string.Empty;
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(cantidad, tipo)} | Área {area:#.##} | Perímetro {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        public string GetListaVacia()
        {
            return "<h1>Lista vazia de formas!</h1>";
        }

        public string GetHeader()
        {
            return "<h1>Relatório de Formas</h1>";
        }

        public string GetTotalFormas(int total)
        {
            return total + " formas ";
        }

        public string GetTotalPerimetros(decimal total)
        {
            return "Perímetro " + total.ToString("#.##") + " ";
        }

        public string GetTotalArea(decimal total)
        {
            return "Área " + total.ToString("#.##") + " ";
        }
    }
}