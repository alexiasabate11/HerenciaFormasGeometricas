using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFormasGeometricas
{
    public class Rombo : Cuadrado
    {
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }
        public double Base
        {
            get { return Lado; }
        }

        public Rombo(double Diagonal1, double Diagonal2, double Base) : base(Base)
        {
            this.Diagonal1 = Diagonal1;
            this.Diagonal2 = Diagonal2;
        }

        public override double CalcularArea()
        {
            return (Diagonal1 * Diagonal2) / 2;
        }

        public override string ToString()
        {
            return $"{eForma.Rombo}: Lado = {Base}, Diagonal Mayor = {Diagonal1}, Diagonar Menor = {Diagonal2}, Área = {CalcularArea()}, Perímetro = {CalcularPerimetro()}";
        }
    }
}
