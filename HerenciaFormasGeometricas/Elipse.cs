using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFormasGeometricas
{
    public class Elipse : Forma
    {
        public double RadioMayor { get; set; }
        public double RadioMenor { get; set; }

        public Elipse(double RadioMayor, double RadioMenor) :base((eForma)4)
        {
            this.RadioMayor = RadioMayor;
            this.RadioMenor = RadioMenor;
        }

        public override double CalcularArea()
        {
            return Math.PI * RadioMayor * RadioMenor;
        }

        public override string ToString()
        {
            return $"Elipse: Radio mayor = {RadioMayor}, Radio menor = {RadioMenor}, Área = {CalcularArea()}";
        }
    }
}
