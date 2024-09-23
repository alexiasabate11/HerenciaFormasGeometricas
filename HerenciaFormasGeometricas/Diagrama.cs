using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFormasGeometricas
{
    internal class Diagrama
    {
        List<Forma> formaList = new List<Forma>();
        double areas = 0;
        double perimetros = 0;

        public Diagrama(int numeroFormas) 
        {
            for (int i = 0; i < numeroFormas; i++) 
            {
                Random random = new Random();
                Forma nuevaForma = new Forma((eForma)random.Next(0,6));
            }
            CalcularAreasYPerimetros();
        }

        public void CalcularAreasYPerimetros()
        {
            foreach (Forma forma in formaList)
            {
                Random random = new Random();
                switch (forma.tipoForma)
                {
                    case eForma.Circulo:
                        Circulo circulo = new Circulo(random.Next());
                        areas =+ circulo.CalcularArea();
                        perimetros =+ circulo.CalcularPerimetro();
                        break;
                    case eForma.Rectangulo:
                        Rectangulo rectangulo = new Rectangulo(random.Next(), random.Next());
                        areas =+ rectangulo.CalcularArea();
                        perimetros =+ rectangulo.CalcularPerimetro();
                        break;
                    case eForma.Triangulo:
                        Triangulo triangulo = new Triangulo(random.Next(), random.Next(), random.Next());
                        areas =+ triangulo.CalcularArea();
                        perimetros =+ triangulo.CalcularPerimetro();
                        break;
                    case eForma.Cuadrado:
                        Cuadrado cuadrado = new Cuadrado(random.Next());
                        areas =+ cuadrado.CalcularArea();
                        perimetros = +cuadrado.CalcularPerimetro();
                        break;
                    case eForma.Elipse:
                        Elipse elipse = new Elipse(random.Next(), random.Next());
                        areas =+ elipse.CalcularArea();
                        perimetros =+ elipse.CalcularPerimetro();
                        break;
                    case eForma.Rombo:
                        Rombo rombo = new Rombo(random.Next(), random.Next(), random.Next());
                        areas =+ rombo.CalcularArea();
                        perimetros =+ rombo.CalcularPerimetro();
                        break;
                }
            }
        }

        public override string ToString()
        {
            foreach(Forma forma in formaList)
            {
                return forma.tipoForma.ToString();
            }
            return "";
        }

    }
}
