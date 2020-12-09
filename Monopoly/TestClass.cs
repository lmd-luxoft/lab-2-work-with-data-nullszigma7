// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using Monopoly.Fields;
using NUnit.Framework;

namespace Monopoly
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void GetPlayersListReturnCorrectList()
        {
            var expectedPlayers = new List<Player>
            {
                new Player { Name = "Peter", Cash = 6000},
                new Player { Name = "Ekaterina", Cash = 6000},
            };

            Monopoly monopoly = new Monopoly(new string[] { "Peter", "Ekaterina" });
            var actualPlayers = monopoly.GetPlayers();

            Assert.AreEqual(expectedPlayers[0].Name, actualPlayers[0].Name);
            Assert.AreEqual(expectedPlayers[0].Cash, actualPlayers[0].Cash);

            Assert.AreEqual(expectedPlayers[1].Name, actualPlayers[1].Name);
            Assert.AreEqual(expectedPlayers[1].Cash, actualPlayers[1].Cash);
        }

        [Test]
        public void GetFieldsListReturnCorrectList()
        {
            var expectedFields = new List<Field>
            {
                new AutoCompany { Name = "Ford" },
                new FoodCompany { Name = "MCDonald" },
                new ClothCompany { Name = "Lamoda" },
                new TravelCompany { Name = "Air Baltic" },
                new TravelCompany { Name = "Nordavia" },
                new Prison { Name = "Prison" },
                new FoodCompany { Name = "MCDonald" },
                new AutoCompany { Name = "TESLA"
            }};

            Monopoly monopoly = new Monopoly(new string[] { "Peter", "Ekaterina", "Alexander" });
            var actualFields = monopoly.GetFields();

            Assert.IsInstanceOf<AutoCompany>(actualFields[0]);
            Assert.IsInstanceOf<AutoCompany>(actualFields[7]);
        }

        [Test]
        public void PlayerBuyNoOwnedCompanies()
        {
            var monopoly = new Monopoly(new string[] { "Peter", "Ekaterina", "Alexander" });
            var field = monopoly.GetFieldByName("Ford");
            var players = monopoly.GetPlayers();
            var player = players[1];

            monopoly.Buy(player, field);

            Assert.AreEqual(player, field.Owner);
        }

        [Test]
        public void RentaShouldBeCorrectTransferMoney()
        {
            var monopoly = new Monopoly(new string[] { "Peter", "Ekaterina", "Alexander" });
            var field = monopoly.GetFieldByName("Ford");
            var players = monopoly.GetPlayers();
            var owner = players[1];
            var player = players[2];

            monopoly.Buy(owner, field);
            monopoly.Renta(player, field);

            Assert.AreEqual(5750, owner.Cash);
            Assert.AreEqual(5750, player.Cash);
        }
    }
}