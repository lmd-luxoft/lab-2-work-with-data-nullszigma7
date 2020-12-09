using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Fields
{
    public class FoodCompany : Field
    {
        public override bool Buy(Player player)
        {
            if (Owner != null)
                return false;

            player.Cash -= 250;

            Owner = player;

            return true;
        }

        public override bool Renta(Player player)
        {
            if (Owner == null)
                return false;

            Owner.Cash += 250;
            player.Cash -= 250;

            return false;
        }
    }
}
