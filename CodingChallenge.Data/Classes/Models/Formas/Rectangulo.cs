using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Models.Formas
{
    public class Rectangulo : FormaGeometricaBase
    {
        public Rectangulo(decimal lado, decimal @base)
            : base(lado, (int)FormasEnum.Rectangulo)
        {
            Base = @base;
        }
        public decimal Base { get;  }

        public override decimal CalcularArea()
        {
            return Base * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado * 2 + Base * 2;
        }
    }
}
