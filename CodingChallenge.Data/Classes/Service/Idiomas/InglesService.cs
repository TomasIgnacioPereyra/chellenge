namespace CodingChallenge.Data.Classes.Models.Idiomas
{
    public class InglesService : ITraductorFormas
    {
        public string TraducirForma(int cantidad, int tipo)
        {
            switch (tipo)
            {
                case (int)FormasEnum.Cuadrado:
                    return cantidad == 1 ? "Square" : "Squares";

                case (int)FormasEnum.Circulo:
                    return cantidad == 1 ? "Circle" : "Circles";

                case (int)FormasEnum.TrianguloEquilatero:
                    return cantidad == 1 ? "Triangle" : "Triangles";

                case (int)FormasEnum.Trapecio:
                    return cantidad == 1 ? "Trapeze" : "Trapezoids";

                case (int)FormasEnum.Rectangulo:
                    return cantidad == 1 ? "Rectangle" : "Rectangles";
            }
            return string.Empty;
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro,int tipo)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(cantidad, tipo)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        public string GetListaVacia()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        public string GetHeader()
        {
            return "<h1>Shapes report</h1>";
        }

        public string GetTotalFormas(int total)
        {
            return total + " shapes ";
        }

        public string GetTotalPerimetros(decimal total)
        {
            return "Perimeter " + total.ToString("#.##") + " ";
        }

        public string GetTotalArea(decimal total)
        {
            return "Area " + total.ToString("#.##") + " ";
        }
    }
}