using lab2.PartTwo.Domain;
using lab2_partOne.Data.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.Parser.ParserExtensions;
using System.Text.RegularExpressions;
using lab2.Data.Core;

namespace lab2.PartTwo.Data.Parser
{
    public class TeamLeagueParser : EntityParser<TeamLeague>
    {
        public override TeamLeague ParseEntity(List<string> values)
        {
            if (values.Count != 8)
            {
                throw new Exception("Invalid values: Length");
            }

            return new TeamLeague
            {
                Name = Regex.Replace(values[0], @"[\d]+\.\s", ""),
                LeagueNumber = (int) values[1].ToDecimal(),
                NumOfWins = (int) values[2].ToDecimal(),
                NumOfLosses = (int) values[3].ToDecimal(),
                NumOfDraws = (int) values[4].ToDecimal(),
                GoalsFor = (int) values[5].ToDecimal(),
                GoalsAgainst = (int) values[6].ToDecimal(),
                Points = (int) values[7].ToDecimal()
            };
        }
    }
}
