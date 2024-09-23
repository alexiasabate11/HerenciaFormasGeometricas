using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFormasGeometricas
{
    public class Rectangulo : Cuadrado
    {
        public double Altura { get; set; }

        public Rectangulo(double Base, double Altura) : base(Base) 
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override string ToString()
        {
            return $"Rectángulo: Base = {Base}, Altrua = {Altura}, Área = {CalcularArea()}";
        }
    }
}
