using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFormasGeometricas
{
    public class Cuadrado : Rectangulo
    {
        public double Lado { get; set; }
        public Cuadrado(double Lado) : base(Lado, Lado)
        {
            this.Lado = Lado;
        }

        public override double CalcularPerimetro()
        {
            return Lado * 4;
        }

        public override string ToString()
        {
            return $"{eForma.Cuadrado}: Lado = {Lado}, Área = {CalcularArea()}, Perímetro = {CalcularPerimetro()}";
        }
    }
}
