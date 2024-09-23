using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFormasGeometricas
{
    public class Triangulo : Poligono
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Diagonal { get; set; }

        public Triangulo(double Base, double Altura, double Diagonal) : base(eForma.Triangulo, 3)
        {
            this.Base = Base;
            this.Altura = Altura;
            this.Diagonal = Diagonal;
        }

        public override double CalcularArea()
        {
            double s = (Altura + Base + Diagonal) / 2;
            return Math.Sqrt(s * (s - Altura) * (s - Base) * (s - Diagonal));
        }

        public override double CalcularPerimetro()
        {
            return Altura + Base + Diagonal;
        }

        public override string ToString()
        {
            return $"{eForma.Triangulo}: Base = {Base}, Altura = {Altura}, Diagonal = {Diagonal}, Área = {CalcularArea()}, Perímetro = {CalcularPerimetro()}";
        }
    }
}
