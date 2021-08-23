using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Models.Formas
{
   public class TrianguloEquilatero : FormaGeometricaBase
    {
        public TrianguloEquilatero(decimal lado)
            : base(lado, (int)FormasEnum.TrianguloEquilatero)
        {
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado * 3;
        }
    }
}
