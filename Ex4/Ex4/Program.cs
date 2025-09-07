using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo phineas = new Triangulo();


            Console.WriteLine("Digite o valor da BASE do triângulo:");
            phineas.setBase1(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o valor da ALTURA do triângulo:");
            phineas.setAltura(double.Parse(Console.ReadLine()));



            phineas.calculaArea();

            Console.WriteLine("O valor da área do triângulo é: {0}", phineas.getArea());
        }
    }
}

