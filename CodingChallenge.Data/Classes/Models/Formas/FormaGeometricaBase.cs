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
    }
}