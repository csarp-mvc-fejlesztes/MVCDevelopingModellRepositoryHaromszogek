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
        public void torolIdAlapjan(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM haromszogek WHERE id=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(id + " rekord törlése nem sikerült!");
                throw new TaroloException("Adatbázis törlési hiba.");
            }
        }
        public void hozzadHaromszoget(Haromszog h)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = h.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(h + " háromszög mentése adatbázisba nem sikerült!");
                throw new TaroloException("Adatbázis rekord beszúrás hiba.");
            }
        }

        public void modositHaromszoget(int id, Haromszog h)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = h.getUpdate(id);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(id + " háromszög módosítása " +h+" háromszögre nem sikerült.");
                throw new TaroloException("Adatbázis rekord módosítási hiba.");
            }
        }
    }
}
