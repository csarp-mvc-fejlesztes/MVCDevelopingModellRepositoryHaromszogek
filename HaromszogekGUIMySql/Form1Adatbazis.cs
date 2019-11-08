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
        private void buttonUresAdatbazisLetrehozasa_Click(object sender, EventArgs e)
        {
            errorProviderAdatbazisLetrehozas.Clear();
            HaromszogekAdatbazis ha = new HaromszogekAdatbazis();
            try
            {
                ha.letrehozAdatbazist();
            }
            catch (Exception ex)
            {
                errorProviderAdatbazisLetrehozas.SetError(
                    buttonUresAdatbazisLetrehozasa,
                    ex.Message
                    );
            }
        }

        private void buttonAdatbazisTorlese_Click(object sender, EventArgs e)
        {
            errorProviderAdatbazisTorles.Clear();
            HaromszogekAdatbazis ha = new HaromszogekAdatbazis();
            try
            {
                ha.torolAdatbazist();
            }
            catch (Exception ex)
            {
                errorProviderAdatbazisTorles.SetError(
                    buttonAdatbazisTorlese,
                    ex.Message
                    );
            }
        }

        private void buttonAdatbazisbaUresTablaLetrehozasa_Click(object sender, EventArgs e)
        {
            errorProviderTablaLetrehozas.Clear();
            HaromszogekAdatbazis ha = new HaromszogekAdatbazis();
            try
            {
                ha.letrehozTablat();
            }
            catch (Exception ex)
            {
                errorProviderTablaLetrehozas.SetError(
                    buttonAdatbazisbaUresTablaLetrehozasa,
                    ex.Message
                    );
            }
        }

        private void buttonTablaTorlese_Click(object sender, EventArgs e)
        {
            errorProviderTablaTorles.Clear();
            HaromszogekAdatbazis ha = new HaromszogekAdatbazis();
            try
            {
                ha.torolTablat();
            }
            catch (Exception ex)
            {
                errorProviderTablaTorles.SetError(
                    buttonTablaTorlese,
                    ex.Message
                    );
            }
        }

        private void buttonMentAdatokatAdatbazisba_Click(object sender, EventArgs e)
        {
            errorProviderMentAdatokAdatbazisba.Clear();
            HaromszogekAdatbazis ha = new HaromszogekAdatbazis();
            try
            {
                ha.feltoltTablatTesztadatokkal(haromszogek.getHaromszogek());
            }
            catch (Exception ex)
            {
                errorProviderMentAdatokAdatbazisba.SetError(
                    buttonMentAdatokatAdatbazisba,
                    ex.Message
                    );
            }
        }

        private void buttonOsszesAdatTorlese_Click(object sender, EventArgs e)
        {
            errorProviderOsszesAdatTorlese.Clear();
            HaromszogekAdatbazis ha = new HaromszogekAdatbazis();
            try
            {
                ha.torolTablabolAdatokat();
            }
            catch (Exception ex)
            {
                errorProviderOsszesAdatTorlese.SetError(
                    buttonOsszesAdatTorlese,
                    ex.Message
                    );
            }
        }
    }
}
