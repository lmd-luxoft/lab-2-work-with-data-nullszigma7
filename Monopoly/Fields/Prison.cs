using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Fields
{
    public class Prison : Field
    {
        public override bool Buy(Player player)
        {
            return false;
        }

        public override bool Renta(Player player)
        {
            player.Cash -= 1000;

            return true;
        }
    }
}