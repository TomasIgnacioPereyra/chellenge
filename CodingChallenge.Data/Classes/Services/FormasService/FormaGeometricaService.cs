using CodingChallenge.Data.Classes.Models;
using CodingChallenge.Data.Classes.Models.Enums;
using CodingChallenge.Data.Classes.Models.Idiomas;
using CodingChallenge.Data.Classes.Service.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes.Service
{
    public class FormaGeometricaService
    {
        private static ITraductorFormas GetTraductor(int idioma)
        {
            switch (idioma)
            {
                case (int)IdiomasEnum.Castellano:
                    return new CastellanoService();

                case (int)IdiomasEnum.Ingles:
                    return new InglesService();

                case (int)IdiomasEnum.Portugues:
                    return new PortuguesService();

                default: throw new ArgumentOutOfRangeException(@"Idioma desconocido");
            }
        }

        public static string Imprimir(List<FormaGeometricaBase> formas, int idioma)
        {
            var traductor = GetTraductor(idioma);

            if (!formas.Any())
                return traductor.GetListaVacia();

            var sb = new StringBuilder();

            // Hay por lo menos una forma
            // HEADER
            sb.Append(traductor.GetHeader());

            //BODY
            SetBody(formas, traductor, sb);

            // FOOTER
            SetFooter(formas, traductor, sb);

            return sb.ToString();
        }
        private static void SetBody(List<FormaGeometricaBase> formas, ITraductorFormas traductor, StringBuilder sb)
        {
            var tiposForma = formas.GroupBy(x => x.Tipo, x => x);

            foreach (var tipoForma in tiposForma)
            {
                var area = tipoForma.Sum(x => x.CalcularArea());
                var perimetro = tipoForma.Sum(x => x.CalcularPerimetro());
                var linea = traductor.ObtenerLinea(tipoForma.Count(), area, perimetro, tipoForma.Key);

                sb.Append(linea);
            }
        }

        private static void SetFooter(List<FormaGeometricaBase> formas, ITraductorFormas traductor, StringBuilder sb)
        {
            sb.Append("TOTAL:<br/>");

            var totalFormas = formas.Count();
            var perimetros = formas.Sum(x => x.CalcularPerimetro());
            var areaTotal = formas.Sum(x => x.CalcularArea());

            sb.Append(traductor.GetTotalFormas(totalFormas));
            sb.Append(traductor.GetTotalPerimetros(perimetros));
            sb.Append(traductor.GetTotalArea(areaTotal));
        }
    }
}