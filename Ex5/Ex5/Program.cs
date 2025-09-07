using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Milhas tioSam = new Milhas();


            Console.WriteLine("Calculadora de milhas marítmas.");
            Console.Write("");


            Console.WriteLine("Digite o valor das milhas marítmas para serem convertidos para quilometros: ");
            tioSam.setMilhas(double.Parse(Console.ReadLine()));

            



            tioSam.calculaArea();

            Console.WriteLine("O valor das milhas convertidas em quilometros é de: {0}KM", tioSam.getQuilometros());
        }
    }
}
