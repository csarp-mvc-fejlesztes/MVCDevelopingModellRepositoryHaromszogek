using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogekSzoftverfejleszto.Modell
{
    partial class Haromszog
    {
        private int id;
        private int a;
        private int b;
        private int c;

        //ha keresünk egy háromszöget le fogjuk kérni az id-jét
        public int getId()
        {
            return id;
        }
        public int getA()
        {
            return a;
        }
        public int getB()
        {
            return b;
        }
        public int getC()
        {
            return c;
        }

        //ha létrejön egy háromszög, akkor kap egy ID-t
        public void setID(int id)
        {
            this.id = id;
        }

        //meglévő háromszög módosításakor használjuk
        public void set(Haromszog ujHaromszogAdatai)
        {
            this.a = ujHaromszogAdatai.getA();
            this.b = ujHaromszogAdatai.getB();
            this.c = ujHaromszogAdatai.getC();
        }

        //a formon új háromszög adatainak megadásakor 
        //létrejön a háromszög
        public Haromszog(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //új háromszög jön létre egy fájl sorból
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
            return "Háromszög: "+a+", "+b + ", "+c;
        }

        
    }
}
