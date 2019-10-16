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
        public int getNextId()
        {
            int max = -1;
            foreach(Haromszog h in haromszogek)
            {
                if (h.getId() > max)
                    max = h.getId();
            }
            return max + 1;
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
        public Haromszog getAdottElem(int index)
        {
            try
            {
                return haromszogek.ElementAt(index);
            }
            catch (TaroloException re)
            {
                Debug.WriteLine(index + ". elem nem létezik.");
            }
            return null;
        }

        //törli az adott id-jű elemet
        public void torolIdAlapjan(int id)
        { /*  int index = 0;
              foreach(Haromszog h in haromszogek)
              {
                  if (h.getId()==id)
                  {
                      haromszogek.RemoveAt(index);
                      return;
                  }
                  index = index + 1;
              }
              return;*/
            haromszogek.RemoveAt(
                haromszogek.FindIndex(h => h.getId() == id));
        }

        //hozzáadja a listához új id-vel a h háromszöget
        public void hozzaadHaromszoget(Haromszog h)
        {
            int id = getNextId();
            h.setID(id);
            haromszogek.Add(h);
        }
        //megkeresi az adott id-jű háromszöget
        //és módosítja az adatait ujHaromszogAdatai-ra
        public void modositHaromszoget(int id, Haromszog ujHaromszogAdatai)
        {
            try
            {
                Haromszog modositandoHaromszog =
                    haromszogek.Find(h => h.getId() == id);
                modositandoHaromszog.set(ujHaromszogAdatai);
            }
            catch (Exception e)
            {
                throw new TaroloException(id + ". háromszög nem létezik!");
            }
        }

        public void torolOsszesAdat()
        {
            haromszogek.Clear();
        }
    }
}
