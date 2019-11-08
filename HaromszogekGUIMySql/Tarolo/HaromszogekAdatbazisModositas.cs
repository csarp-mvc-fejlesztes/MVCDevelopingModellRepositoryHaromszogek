using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Diagnostics;

using HaromszogekSzoftverfejleszto.Tarolo;
using HaromszogekSzoftverfejleszto.Modell;

namespace HaromszogekGUI.Tarolo
{
    partial class HaromszogekAdatbazis
    {
        public void feltoltTablatTesztadatokkal(List<Haromszog> haromszogek)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                foreach(Haromszog h in haromszogek)
                {
                    string query = h.getInsert();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch(Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new TaroloException("Tesztadatok feltöltése sikertelen.");
            }
        }

        public void torolTablabolAdatokat()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Haromszog.getDeleteAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new TaroloException("Tesztadatok törlése sikertelen.");
            }
        }
    }
}
