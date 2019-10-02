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

using HaromszogekGUI.Tarolo;

namespace HaromszogekGUI
{
    public partial class Form1 : Form
    {
        HaromszogekDatabase ham = new HaromszogekDatabase();

        private void buttonUresAdatbazisLetrehozasa_Click(object sender, EventArgs e)
        {
            ham.initializeEmptyDatabase();
        }

        private void buttonAdatbazisbaUresTablaLetrehozasa_Click(object sender, EventArgs e)
        {
            ham.createTable();
        }

        private void buttonMentAdatokatAdatbazisba_Click(object sender, EventArgs e)
        {
            ham.saveDataToDatabase(haromszogek.getHaromszogek());
        }
    }
}
