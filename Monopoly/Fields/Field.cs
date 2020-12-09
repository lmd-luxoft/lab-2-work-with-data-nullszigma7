using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Fields
{
    public abstract class Field
    {
        public string Name { get; set; }
        public Player Owner { get; set; }

        public abstract bool Buy(Player player);
        public abstract bool Renta(Player player);
    }
}