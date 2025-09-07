using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar fvckUSA = new Dolar();


            Console.WriteLine("Calculadora de cotação do dolar.");
            Console.Write("");


            Console.WriteLine("Digite o valor da cotação atual do dolar em reais: ");
            fvckUSA.setCotacao(double.Parse(Console.ReadLine()));

            Console.WriteLine();

            Console.WriteLine("Digite o valor da quantidade de dólares: ");
            fvckUSA.setDolar(double.Parse(Console.ReadLine()));






            fvckUSA.calculaDolar();

            Console.WriteLine("O valor em reais é de: R${0} ", fvckUSA.getReais());
        }
    }
}
