using lab2_partOne.Data.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.PartTwo.Domain
{
    public class TeamLeague : IEntity
    {
        public string Name { get; set; }
        public int LeagueNumber { get; set; }
        public int NumOfWins { get; set; }
        public int NumOfLosses { get; set; }
        public int NumOfDraws { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int Points { get; set; }

        public decimal GetDifferenceBetweenTargetProperties()
        {
            return Math.Abs(GoalsFor - GoalsAgainst);
        }

        public object GetIndicator()
        {
            return Name;
        }
    }
}
