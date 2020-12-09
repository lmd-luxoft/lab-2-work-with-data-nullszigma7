using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Fields
{

    public class ClothCompany : Field
    {
        public override bool Buy(Player player)
        {
            if (Owner != null)
                return false;

            player.Cash -= 100;

            Owner = player;

            return true;
        }

        public override bool Renta(Player player)
        {
            if (Owner == null)
                return false;

            Owner.Cash += 1000;
            player.Cash -= 100;

            return true;
        }
    }
}
