using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogekSzoftverfejleszto.Modell
{
    partial class Haromszog
    {
        public string getMysqlInsertCommand()
        {
            return "INSERT INTO `haromszogek` (`id`, `aoldal`, `boldal`, `coldal`) VALUES('" +
                getId() +
                "', '" +
                getA() +
                "', '" +
                getB() +
                "', '" +
                getC() +
                "');";
        }

        static public string getMysqlDeleteCommand(int id)
        {
            return "DELETE FROM haromszogek WHERE id=\"" + id + "\"";
        }

        public string getMysqlUpdateCommand(int id)
        {
            return "UPDATE `haromszogek` SET `aoldal` = '" +
                 getA() +
                "', `boldal` = '" +
                getB() +
                "', `coldal` = '" +
                getC() +
                "' WHERE `haromszogek`.`id` = " + id;
        }

        public  static string getMysqlDeleteAllCommand()
        {
            return  "DELETE FROM haromszogek";
        }
    }
}
