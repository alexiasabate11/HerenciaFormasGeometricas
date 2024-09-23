using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFormasGeometricas
{
    public class Cuadrado : Poligono
    {
        public double Base { get; set; }
        public Cuadrado(double Lado) : base((eForma)3,4)
        {
            this.Base = Base;
        }

        public override double CalcularArea()
        {
            return Base * Base;
        }

        public override string ToString()
        {
            return $"Cuadrado: Lado = {Base}, Área = {CalcularArea()}";
        }
    }
}
