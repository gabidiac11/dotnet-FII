using lab2.PartTwo.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Tests
{
    [TestClass]
    public class TeamLeagueParserTests
    {
        private static readonly TeamLeague AstonVilla = new TeamLeague {
            Name = "Aston_Villa",
            LeagueNumber = 38,
            NumOfWins = 12,
            NumOfLosses = 14,
            NumOfDraws = 12,
            GoalsFor = 46,
            GoalsAgainst = 47,
            Points = 50
        };

        [TestMethod]
        public void TestParseTeams()
        {
            var items = new PartTwo.Program(new PartTwo.Data.TeamLeagueProvider()).Items;

            Assert.AreEqual(20, items.Count);

            var foundAstonVilla = items.FirstOrDefault(item => item.Name == AstonVilla.Name);

            Assert.AreEqual(AstonVilla.Name, foundAstonVilla.Name);
            Assert.AreEqual(AstonVilla.LeagueNumber, foundAstonVilla.LeagueNumber);
            Assert.AreEqual(AstonVilla.NumOfWins, foundAstonVilla.NumOfWins);
            Assert.AreEqual(AstonVilla.NumOfLosses, foundAstonVilla.NumOfLosses);
            Assert.AreEqual(AstonVilla.NumOfDraws, foundAstonVilla.NumOfDraws);
            Assert.AreEqual(AstonVilla.GoalsFor, foundAstonVilla.GoalsFor);
            Assert.AreEqual(AstonVilla.GoalsAgainst, foundAstonVilla.GoalsAgainst);
            Assert.AreEqual(AstonVilla.Points, foundAstonVilla.Points);


        }
    }
}
