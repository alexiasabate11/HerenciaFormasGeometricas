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

        public Elipse(double RadioMayor, double RadioMenor) :base(eForma.Elipse)
        {
            this.RadioMayor = RadioMayor;
            this.RadioMenor = RadioMenor;
        }

        public override double CalcularArea()
        {
            return Math.PI * RadioMayor * RadioMenor;
        }

        public override double CalcularPerimetro()
        {
            return Math.PI * (3 * (RadioMayor + RadioMenor) - Math.Sqrt((3 * RadioMayor + RadioMenor) * (RadioMayor + 3 * RadioMenor)));
        }

        public override string ToString()
        {
            return $"{eForma.Elipse}: Radio mayor = {RadioMayor}, Radio menor = {RadioMenor}, Área = {CalcularArea()}, Perímetro = {CalcularPerimetro()}";
        }
    }
}
