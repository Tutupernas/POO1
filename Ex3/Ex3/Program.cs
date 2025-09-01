using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrads becoDiagonal = new Quadrads();


            Console.WriteLine("Digite o valor da diagonal do quadrado");
            becoDiagonal.setDiag(double.Parse(Console.ReadLine()));

            becoDiagonal.calculaArea();

            Console.WriteLine("O valor da área do quadrado é: {0}", becoDiagonal.getArea());
        }
    }
}
