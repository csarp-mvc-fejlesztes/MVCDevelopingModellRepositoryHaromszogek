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
        

    }
}
