using Monopoly.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Monopoly
    {
        private List<Player> _players = new List<Player>();
        private List<Field> _fields = new List<Field>();

        public Monopoly(string[] playerNames)
        {
            for (int i = 0; i < playerNames.Length; i++)
                _players.Add(new Player { Name = playerNames[i], Cash = 6000 });

            _fields.Add(new AutoCompany { Name = "Ford" });
            _fields.Add(new FoodCompany { Name = "MCDonald" });
            _fields.Add(new ClothCompany { Name = "Lamoda" });
            _fields.Add(new TravelCompany { Name = "Air Baltic" });
            _fields.Add(new TravelCompany { Name = "Nordavia" });
            _fields.Add(new Prison { Name = "Prison" });
            _fields.Add(new FoodCompany { Name = "MCDonald" });
            _fields.Add(new AutoCompany { Name = "TESLA" });
        }

        internal List<Field> GetFields() => _fields;

        internal List<Player> GetPlayers() => _players;

        internal Field GetFieldByName(string name) => _fields.FirstOrDefault(f => f.Name == name);

        internal bool Buy(Player player, Field field) => field.Buy(player);

        internal bool Renta(Player player, Field field) => field.Renta(player);
    }
}