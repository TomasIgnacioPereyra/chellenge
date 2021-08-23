using CodingChallenge.Data.Classes.Models.Formas;
using System;

namespace CodingChallenge.Data.Classes.Models
{
    public abstract class FormaGeometricaBase
    {
        public FormaGeometricaBase(decimal lado, int tipo)
        {
            Lado = lado;
            Tipo = tipo;
        }

        public decimal Lado { get; }
        public int Tipo { get; }

        public abstract decimal CalcularPerimetro();

        public abstract decimal CalcularArea();

        public static FormaGeometricaBase GetNewForma(decimal lado, int tipo, decimal @base = 0)
        {
            switch (tipo)
            {
                case (int)FormasEnum.Circulo:
                    return new Circulo(lado);

                case (int)FormasEnum.Cuadrado:
                    return new Cuadrado(lado);

                case (int)FormasEnum.TrianguloEquilatero:
                    return new TrianguloEquilatero(lado);

                case (int)FormasEnum.Rectangulo:
                    @base = @base == 0 ? lado : @base;
                    return new Rectangulo(lado, @base);

                default: throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }
    }
}