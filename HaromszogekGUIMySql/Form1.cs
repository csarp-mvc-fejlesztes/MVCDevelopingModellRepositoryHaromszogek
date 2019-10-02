using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HaromszogekGUI.Tarolo;
using HaromszogekSzoftverfejleszto.Modell;
using HaromszogekSzoftverfejleszto.Tarolo;

namespace HaromszogekGUI
{
    public partial class Form1 : Form
    {
        //repository (tároló)
        Haromszogek haromszogek;
        HaromszogekDatabase haromszogekDatabase;

        public Form1()
        {
            //repository (tároló) példányosítása
            haromszogek = new Haromszogek();
            haromszogekDatabase = new HaromszogekDatabase();
            InitializeComponent();
        }

        private void buttonBeolvas_Click(object sender, EventArgs e)
        {
            //beolvas a fájlból 
            haromszogek.beolvas();
            //adatokat megjelenit a ListBox-ban
            megjelenitHaromszogeketListboxban();
        }

        private void listBoxHaromszogek_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxHaromszogek.SelectedIndex;
            if (index < 0) //üres a ListBox
                return;
            try
            {
                //kiválasztott háromszög lekérése és megjelenítése
                Haromszog h = haromszogek.getAdottElem(index);
                megjelenitHaromszoget(h);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void megjelenitHaromszoget(Haromszog h)
        {
            textBoxAOldal.Text = h.getA().ToString();
            textBoxBOldal.Text = h.getB().ToString();
            textBoxCOldal.Text = h.getC().ToString();
        }

        private void megjelenitHaromszogeketListboxban()
        {
            //ListBox törlése majd adatokkal feltöltése
            listBoxHaromszogek.DataSource = null;
            listBoxHaromszogek.DataSource = haromszogek.getHaromszogek();
        }


        private void buttonTorol_Click(object sender, EventArgs e)
        {
            int index = listBoxHaromszogek.SelectedIndex;
            if (index < 0)
                return;
            try
            {
                //kiválasztott elem
                Haromszog h = haromszogek.getAdottElem(index);
                //id-jét megkeressük, töröljük
                int id = h.getId();
                haromszogek.torolIdAlapjan(id);
                haromszogekDatabase.removeFromDatabase(id);
                //majd frissítjük a ListBox-ot
                megjelenitHaromszogeketListboxban();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void buttonUjOldal_Click(object sender, EventArgs e)
        {
            errorProviderA.SetError(textBoxAOldal, "");
            errorProviderA.SetError(textBoxBOldal, "");
            errorProviderA.SetError(textBoxCOldal, "");
            bool vanHiba = false;
            int a = 0;
            try
            {
                a = Convert.ToInt32(textBoxAOldal.Text);
            }
            catch (Exception ex)
            {
                errorProviderA.SetError(textBoxAOldal, "Hibás adat!");
                vanHiba = true;
            }
            int b = 0;
            try
            {
                b = Convert.ToInt32(textBoxBOldal.Text);
            }
            catch (Exception ex)
            {
                errorProviderB.SetError(textBoxBOldal, "Hibás adat!");
                vanHiba = true;
            }
            int c = 0;
            try
            {
                c = Convert.ToInt32(textBoxCOldal.Text);

            }
            catch (Exception ex)
            {
                errorProviderC.SetError(textBoxCOldal, "Hibás adat!");
                vanHiba = true;
            }
            if (!vanHiba)
            {
                //A jó adatokkal létrehozzuk a háromszöget
                Haromszog h = new Haromszog(a, b, c);
                //A létrehozott háromszöget hozzáadjuk a repository-hoz
                haromszogek.hozzaadHaromszoget(h);
                haromszogekDatabase.add(h);
                //Megjelenítjük az új háromszöggel a háromszögeket a Listboxban
                megjelenitHaromszogeketListboxban();
            }
        }

        private void buttonModosit_Click(object sender, EventArgs e)
        {
            errorProviderA.SetError(textBoxAOldal, "");
            errorProviderA.SetError(textBoxBOldal, "");
            errorProviderA.SetError(textBoxCOldal, "");
            bool vanHiba = false;
            int a = 0;
            try
            {
                a = Convert.ToInt32(textBoxAOldal.Text);
            }
            catch (Exception ex)
            {
                errorProviderA.SetError(textBoxAOldal, "Hibás adat!");
                vanHiba = true;
            }
            int b = 0;
            try
            {
                b = Convert.ToInt32(textBoxBOldal.Text);
            }
            catch (Exception ex)
            {
                errorProviderB.SetError(textBoxBOldal, "Hibás adat!");
                vanHiba = true;
            }
            int c = 0;
            try
            {
                c = Convert.ToInt32(textBoxCOldal.Text);

            }
            catch (Exception ex)
            {
                errorProviderC.SetError(textBoxCOldal, "Hibás adat!");
                vanHiba = true;
            }
            if (!vanHiba)
            {
                //Kell a kijelölt elem, mert őt módosítjuk
                int index = listBoxHaromszogek.SelectedIndex;
                if (index < 0) //üres a ListBox
                    return;
                Haromszog modositando = haromszogek.getAdottElem(index);
                //Lekérjük a módosítandó elem ID-jét 
                int id = modositando.getId();
                //Létrehozzuk a háromszöget
                Haromszog h = new Haromszog(a, b, c);
                //A repositoryban az adott id-vel rendelekező háromszoget módosítjuk az új h háromszögre
                haromszogek.modositHaromszoget(id, h);
                haromszogekDatabase.updateDatabase(id, h);
                //Frissítjük a ListBox-ot az új adatokkal
                megjelenitHaromszogeketListboxban();
            }

        }


    }
}
