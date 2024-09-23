using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFormasGeometricas
{
    public class Circulo : Elipse
    {
        public double Radio {
            get { return RadioMayor; } 
            set 
            { 
                RadioMayor = value; 
                RadioMenor = value;
            }
        }

        public Circulo(double Radio): base(Radio, Radio) { }

        public override string ToString() 
        {
            return $"Círculo: Radio = {Radio}, Área = {CalcularArea()}";
        }
    }
}
