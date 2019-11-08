using HaromszogekSzoftverfejleszto.Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Diagnostics;

namespace HaromszogekSzoftverfejleszto.Tarolo
{
    class Haromszogek
    {
        //lista a háromszögek tárolására
        List<Haromszog> haromszogek;

        public Haromszogek()
        {
            //lista példányosítása
            haromszogek = new List<Haromszog>();
        }

        //visszaadja a teljes listát
        public List<Haromszog> getHaromszogek()
        {
            return haromszogek;
        }

        // új háromszög lehetséges ID-je
        // MEGÍRANDÓ metódus
        public int getNextId()
        {
            return 0;
        }

        //háromszög adatainak beolvasása a fájlból
        public void beolvas()
        {
            try
            {
                StreamReader sr = new StreamReader("../../01haromszogek.txt");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    try
                    {
                        Haromszog h = new Haromszog(line);
                        h.setID(getNextId());
                        haromszogek.Add(h);
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                }
            } catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public int getHaromszogekSzama()
        {
            return haromszogek.Count;
        }

        public bool szerkeszthetoE(int n)
        {
            try
            {
                if (haromszogek.ElementAt(n).szerkeszthetoE())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new TaroloException(n + ". háromszög nem létezik!");
            }
        }

        public double getSzerkeszthetoHaromszogekOsszterulete()
        {
            double terulet = 0;
            foreach(Haromszog h in haromszogek)
            {
                if (h.szerkeszthetoE())
                    terulet = terulet + h.getTerulet();
            }
            return terulet;
        }

        //a listában kijelölt elem
        // MEGÍRANDÓ
        public Haromszog getAdottElem(int index)
        {
            return null;
        }
    }
}
