using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFormasGeometricas
{
    public class Circulo : Elipse
    {
        public double Radio 
        { 
            get { return RadioMayor; } 
        }

        public Circulo(double Radio): base(Radio, Radio) { }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override string ToString() 
        {
            return $"{eForma.Circulo}: Radio = {Radio}, Área = {CalcularArea()}, Perímetro = {CalcularPerimetro()}";
        }
    }
}
