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
using HaromszogekSzoftverfejleszto.Modell;
using HaromszogekSzoftverfejleszto.Tarolo;

namespace HaromszogekGUI
{
    public partial class Form1 : Form
    {
        //repository (tároló)
        Haromszogek haromszogek;

        public Form1()
        {
            //repository (tároló) példányosítása
            haromszogek = new Haromszogek();
            InitializeComponent();
        }

        private void buttonBeolvas_Click(object sender, EventArgs e)
        {
            //beolvas a fájlból 
            haromszogek.beolvas();

        }

       
    }
}
