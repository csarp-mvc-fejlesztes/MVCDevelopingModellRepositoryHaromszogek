using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogekSzoftverfejleszto.Modell
{
    partial class Haromszog
    {
        public string getInsert()
        {
            return 
                "INSERT INTO `haromszogek` (`id`, `aoldal`, `boldal`, `coldal`) " +
                "VALUES ('" +
                id +
                "', '" +
                getA() +
                "', '" +
                getB() +
                "', '" +
                getC() +
                "');";
        }

        public string getUpdate(int id)
        {
            return
                "UPDATE `haromszogek`" +
                " SET `aoldal` = '" +
                getA() +
                "', `boldal` = '" +
                getB() +
                "', `coldal` = '" +
                getC() +
                "' WHERE `haromszogek`.`id` =" + id;
                
        }

        public static string getDeleteAllRecord()
        {
            return "DELETE FROM haromszogek";
        }
    }
}