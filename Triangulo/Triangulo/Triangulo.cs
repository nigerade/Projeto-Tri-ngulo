using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Triangulo
    {
        public double lado1;
        public double lado2;
        public double lado3;
        public String classificacao;
        public double perimetro;
        public double area;

        public Triangulo()
        {
            lado1 = 0.0;
            lado2 = 0.0;
            lado3 = 0.0;
            classificacao = "";
            perimetro = 0.0;
            area = 0.0;
        }

        public Triangulo(
        double Lado1,
        double Lado2, 
        double Lado3, 
        string Classificao, 
        double Perimetro, 
        double Area)
        
        {
            lado1 = Lado1;
            lado2 = Lado2;
            lado3 = Lado3;
            classificacao = Classificao;
            perimetro = Perimetro;
            area = Area;
        }

        public Triangulo(
            double Lado1, double Lado2, double Lado3)
        {
            lado1 = Lado1;
            lado2 = Lado2;
            lado3 = Lado3;
        }

        public Boolean IsTriangle ()
        {
            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
            {
                Classificar();
                CalcularArea();
                return true;

            }
            return false;
        }

        public void CalcularPerimetro()
        {
            perimetro = lado1 + lado2 + lado3;
        }

        public void Classificar()
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                classificacao = "Equilátero";
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                classificacao = "Isósceles";
            }
            else{
                classificacao = "Escaleno";
            }
        }

        public void CalcularArea()
        {
            CalcularPerimetro();
           double sp = perimetro / 2;
           area= Math.Sqrt(sp * (sp - lado1) * (sp - lado2) * (sp - lado3) ); 
        }

        
    }
}
