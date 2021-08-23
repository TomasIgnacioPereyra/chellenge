using System;

namespace CodingChallenge.Data.Classes.Models
{
    public class Circulo : FormaGeometricaBase
    {
        public Circulo(decimal lado)
            : base(lado, (int)FormasEnum.Circulo)
        {
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (Lado / 2) * (Lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * Lado;
        }
    }
}