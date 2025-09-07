using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Milhas
    {
        double milhas;
        double milhasMaritimas;
        double quilometros;

        public Milhas()
        {
            this.milhas = 0;
            this.milhasMaritimas = 1852;
            this.quilometros = 0;

        }

        public void setMilhas(double milhas)
        {


            this.milhas = milhas;

        }

        public double getMilha()
        {

            return this.milhas;

        }
        

        public double getQuilometros()
        {

            return this.quilometros;

        }

        public void calculaArea()
        {

            this.quilometros = (this.milhas * this.milhasMaritimas) / 1000;
        }
    }
}
