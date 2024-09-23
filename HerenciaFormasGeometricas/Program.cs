using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFormasGeometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }

        static void Ejecutar()
        {
            int menu;
            do
            {
                menu = Menu();

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Radio del circulo:");
                        Circulo circulo = new Circulo(PedirNumero());
                        Console.WriteLine(circulo.ToString());
                        break;
                    case 2:
                        Console.WriteLine("Base y altura del rectangulo: ");
                        Rectangulo rectangulo = new Rectangulo(PedirNumero("Base: "), PedirNumero("Altura: "));
                        Console.WriteLine(rectangulo.ToString());
                        break;
                    case 3:
                        Console.WriteLine("Base y altura del triangulo: ");
                        Triangulo triangulo = new Triangulo(PedirNumero("Base: "), PedirNumero("Altura: "));
                        Console.WriteLine(triangulo.ToString());
                        break;
                    case 4:
                        Console.WriteLine("Base del cuadrado: ");
                        Cuadrado cuadrado = new Cuadrado(PedirNumero());
                        Console.WriteLine(cuadrado.ToString());
                        break;
                    case 5:
                        Console.WriteLine("Radio mayor y radio menor del elipse: ");
                        Elipse elipse = new Elipse(PedirNumero("Radio Mayor: "), PedirNumero("Radio Menor: "));
                        Console.WriteLine(elipse.ToString());
                        break;
                    case 0:
                        return;
                }
                if (menu < 1 || menu > 5) return;
                Console.WriteLine();
            }
            while (true);
        }

        static int Menu()
        {
            Console.WriteLine(@"
Que forma quieres calcular?
1. Circulo
2. Rectangulo
3. Triangulo
4. Cuadrado
5. Elipse
0. Salir
");
            int numeroForma = PedirNumero();
            Console.WriteLine();
            return numeroForma;
        }

        static int PedirNumero(string texto)
        {
            Console.WriteLine(texto);
            Int32.TryParse(Console.ReadLine(), out int numero);
            return numero;
        }

        static int PedirNumero()
        {
            Int32.TryParse(Console.ReadLine(), out int numero);
            return numero;
        }
    }
}
