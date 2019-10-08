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
    }
}
