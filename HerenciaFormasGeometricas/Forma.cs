using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFormasGeometricas
{
    public enum eForma
    {
        Circulo,
        Rectangulo,
        Triangulo,
        Cuadrado,
        Elipse
    }
    public class Forma
    {
        public eForma tipoForma;

        public Forma(eForma tipoForma)
        {
            this.tipoForma = tipoForma;
        }

        public virtual double CalcularArea()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Forma : {tipoForma}";
        }
    }
}
