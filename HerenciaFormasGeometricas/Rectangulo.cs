using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFormasGeometricas
{
    public class Rectangulo : Poligono
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double Base, double Altura) : base(eForma.Rectangulo, 4) 
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return Base * 2 + Altura * 2;
        }

        public override string ToString()
        {
            return $"{eForma.Rectangulo}: Base = {Base}, Altrua = {Altura}, Área = {CalcularArea()}, Perímetro = {CalcularPerimetro()}";
        }
    }
}
