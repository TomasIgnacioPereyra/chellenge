namespace CodingChallenge.Data.Classes.Models.Formas
{
    public class Cuadrado : FormaGeometricaBase
    {
        public Cuadrado(decimal lado)
            : base(lado, (int)FormasEnum.Cuadrado)
        {
        }

        public override decimal CalcularArea()
        {
            return Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado * 4;
        }
    }
}