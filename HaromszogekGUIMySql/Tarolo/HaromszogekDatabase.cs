using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using MySql.Data.MySqlClient;
using HaromszogekSzoftverfejleszto.Modell;

namespace HaromszogekGUI.Tarolo
{
    class HaromszogekDatabase
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        public HaromszogekDatabase()
        {
            connectionStringCreate =
               "SERVER=\"localhost\";"
               + "DATABASE=\"test\";"
               + "UID=\"root\";"
               + "PASSWORD=\"\";"
               + "PORT=\"3307\";";

            connectionString =
                "SERVER=\"localhost\";"
                + "DATABASE=\"haromszogek\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3307\";";
        }

        public void initializeEmptyDatabase()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionStringCreate);
                connection.Open();


                string query = "DROP DATABASE IF EXISTS haromszogek;";
                MySqlCommand cmdCreate = new MySqlCommand(query, connection);
                cmdCreate.ExecuteNonQuery();

                query = "CREATE DATABASE haromszogek DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;USE haromszogek";
                cmdCreate = new MySqlCommand(query, connection);
                cmdCreate.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public void createTable()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();


                string query = "CREATE TABLE `haromszogek` (" +
                           " `id` int(11) NOT NULL," +
                           " `aoldal` int(11) NOT NULL," +
                           " `boldal` int(11) NOT NULL," +
                           " `coldal` int(11) NOT NULL " +
                       " ) ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci; "; 
                       
                MySqlCommand cmdCreate = new MySqlCommand(query, connection);
                cmdCreate.ExecuteNonQuery();

                query=" ALTER TABLE `haromszogek`  ADD PRIMARY KEY(`id`); ";
                cmdCreate = new MySqlCommand(query, connection);
                cmdCreate.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public void saveDataToDatabase(List<Haromszog> haromszogek)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string query = "";
                MySqlCommand cmdCreate = new MySqlCommand(query, connection);
              
                foreach (Haromszog h in haromszogek)
                {
                    query = h.getMysqlInsertCommand();
                    MySqlCommand cmdInsert = new MySqlCommand(query, connection);
                    cmdInsert.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public void add(Haromszog item)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = item.getMysqlInsertCommand();
                MySqlCommand cmdInsert = new MySqlCommand(query, connection);
                cmdInsert.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return;
        }

        public void removeFromDatabase(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = Haromszog.getMysqlDeleteCommand(id);
                MySqlCommand cmdDelete = new MySqlCommand(query, connection);
                cmdDelete.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return;

        }

        public void updateDatabase(int id, Haromszog h)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = h.getMysqlUpdateCommand(id);
                MySqlCommand cmdUpdate = new MySqlCommand(query, connection);
                cmdUpdate.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return;

        }

        public void removeAllDataFromDatabase()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = Haromszog.getMysqlDeleteAllCommand();
                MySqlCommand cmdUpdate = new MySqlCommand(query, connection);
                cmdUpdate.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return;
        }

        public void removeTable()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "DROP TABLE haromszogek;";
                MySqlCommand cmdDeleteTAble = new MySqlCommand(query, connection);
                cmdDeleteTAble.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public void removeDatabase()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "DROP DATABASE haromszogek;";
                MySqlCommand cmdDeleteDatabase = new MySqlCommand(query, connection);
                cmdDeleteDatabase.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

        }
    }
}
