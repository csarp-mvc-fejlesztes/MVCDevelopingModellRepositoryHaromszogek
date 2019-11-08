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
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        /// <summary>
        /// Konstruktor - kezdőértékadások
        /// </summary>
        public HaromszogekAdatbazis()
        {
            connectionStringCreate =
                "SERVER=\"localhost\";"
                + "DATABASE=\"test\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3306\";";
            connectionString =
                "SERVER=\"localhost\";"
                + "DATABASE=\"csarp\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3306\";";
        }
        
        /// <summary>
        /// Létrehozza a "csarp" adatbazist
        /// </summary>
        public void letrehozAdatbazist()
        {
            string query =
                "CREATE DATABASE IF NOT EXISTS csarp " +
                "DEFAULT CHARACTER SET utf8 " +
                "COLLATE utf8_hungarian_ci ";
                
            MySqlConnection connection =
                new MySqlConnection(connectionStringCreate);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new TaroloException("Adatbázis létrehozás nem sikerült vagy már létezik.");
            }
        }

        /// <summary>
        /// csarp adatbázisban tábla létrehozása
        /// </summary>
        public void letrehozTablat()
        {
            string queryUSE ="USE csarp;";
            string queryCreateTable =
                "CREATE TABLE `csarp`.`haromszogek` ( " +
                "    `id` INT NOT NULL , " +
                "    `aoldal` INT NOT NULL ," +
                "    `boldal` INT NOT NULL ," +
                "    `coldal` INT NOT NULL " +
                ")ENGINE = InnoDB;";
            string queryPrimaryKey =
                "ALTER TABLE `haromszogek` ADD PRIMARY KEY( `id`);";

            MySqlConnection connection =
                new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmdUSE = new MySqlCommand(queryUSE, connection);
                cmdUSE.ExecuteNonQuery();
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new TaroloException("Tábla lérehozása sikertelen.");
            }
        }

        /// <summary>
        /// Haromszogek tábla törlése csarp adatbázisból
        /// </summary>
        public void torolTablat()
        {
            string query =
                "USE csarp; " +
                "DROP TABLE haromszogek;";

            MySqlConnection connection =
                new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new TaroloException("Tábla törlése nem sikerült.");
            }
        }

        /// <summary>
        /// Az adatbázis törlése
        /// </summary>
        public void torolAdatbazist()
        {
            string query =
                "DROP DATABASE csarp;";

            MySqlConnection connection =
                new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new TaroloException("Adatbázis törlése nem sikerült.");
            }
        }       
    }
}
