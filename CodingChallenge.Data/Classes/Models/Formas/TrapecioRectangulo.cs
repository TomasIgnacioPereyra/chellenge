using System;

namespace CodingChallenge.Data.Classes.Models.Formas
{
    public class TrapecioRectangulo : FormaGeometricaBase
    {
        public TrapecioRectangulo(decimal ladoA, decimal baseSuperior, decimal baseInferior)
            : base(ladoA, (int)FormasEnum.Trapecio)
        {
            BaseSuperior = baseSuperior;
            BaseInferior = baseInferior;
            LadoOblicuo = GetPerpendicular();
        }

        public decimal BaseSuperior { get; }
        public decimal BaseInferior { get; }
        public decimal LadoOblicuo { get; }

        public override decimal CalcularArea()
        {
            return (BaseInferior + BaseSuperior) / 2 * Lado;
        }

        private decimal GetPerpendicular()
        {
            var x = Math.Pow((double)Lado, 2) + Math.Pow((double)(BaseInferior - BaseSuperior), 2);

            return (decimal)Math.Sqrt(x);
        }

        public override decimal CalcularPerimetro()
        {
            return BaseSuperior + BaseInferior + LadoOblicuo + Lado;
        }
    }
}