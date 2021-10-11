using lab2.PartTwo.Data.Parser;
using lab2.PartTwo.Domain;
using lab2_partOne.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.PartTwo.Data
{
    public class TeamLeagueProvider : Provider<TeamLeague>
    {
        public TeamLeagueProvider()
        {
            Parser = new TeamLeagueParser();
            Source = "C:/Users/Gabi/source/repos/lab1/lab2.PartTwo/Data/Files/football.dat";
        }
    }
}
