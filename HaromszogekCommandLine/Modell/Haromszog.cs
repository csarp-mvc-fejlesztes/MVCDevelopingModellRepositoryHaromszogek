using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogekSzoftverfejleszto.Modell
{
    class Haromszog
    {
        private int a;
        private int b;
        private int c;

        public Haromszog(string sor)
        {
            string[] adat = sor.Split(' ');

            try
            {
                a = Convert.ToInt32(adat[0]);
                b = Convert.ToInt32(adat[1]);
                c = Convert.ToInt32(adat[2]);
            }
            catch (Exception e)
            {
                throw new ModellException("A háromszög adatok hibásak a fájlban: " + sor);
            }
        }

        public bool szerkeszthetoE()
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
                return true;
            else
                return false;
        }

        public double getTerulet()
        {
            double s = (a + b + c) / 2;
            double t = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return t;
        }

        public override string ToString()
        {
            return "Hárömszög: "+a+", "+b + ", "+c;
        }

    }
}
