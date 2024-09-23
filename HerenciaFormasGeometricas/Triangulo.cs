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

        public Triangulo(double Base, double Altura) : base((eForma)2, 3)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override string ToString()
        {
            return $"Triángulo: Base = {Base}, Altura = {Altura}, Área = {CalcularArea()}";
        }
    }
}
