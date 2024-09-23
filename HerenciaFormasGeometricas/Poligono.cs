using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFormasGeometricas
{
    public class Poligono : Forma
    {
        public int NumeroLados { get; set; }

        public Poligono(eForma tipoForma, int NumeroLados) : base(tipoForma)
        {
            this.NumeroLados = NumeroLados;
        }

        public override string ToString()
        {
            return $"Poligono: {tipoForma}, Lados: {NumeroLados}";
        }
    }
}
