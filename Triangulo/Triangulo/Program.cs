using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Triangulo triangulo = new Triangulo();
            int op = 0;

            do
            {
                

                Console.WriteLine("Selecione uma Opção:\n" +
                    "1- Iniciar\n2- Fechar Programa");
                op = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Lado 1 do Triângulo: ");
                        triangulo.lado1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Lado 2 do Triângulo: ");
                        triangulo.lado2 = double.Parse(Console.ReadLine());


                        Console.WriteLine("Lado 3 do Triângulo: ");
                        triangulo.lado3 = double.Parse(Console.ReadLine());
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;

                }

                if (triangulo.IsTriangle())
                {
                    Console.WriteLine("A classificação é: " + triangulo.classificacao + "\n" + "Área do Triângulo: "+ triangulo.area + "\n" + "Perímetro do triângulo: " + triangulo.perimetro + "\n");

                }
                else
                {
                    Console.WriteLine("Triâgulo inválido!!!");
                }
                




            } while (op != 2);
        }
      }
 }

