using lab2.PartTwo.Domain;
using lab2_partOne.Data.Core;
using lab2_partOne.Data.Core.Interfaces;
using System;

namespace lab2.PartTwo
{
    public class Program : Instance<TeamLeague>
    {
        public Program(IProvider<TeamLeague> provider) : base(provider) { }

        public override void PrintResult(TeamLeague result)
        {
            if (result != null)
            {
                Console.WriteLine($"Result: The team name with the lowest difference between F-A:  {(string)result.GetIndicator()}, of value {result.GetDifferenceBetweenTargetProperties()} ");
                return;
            }

            Console.WriteLine($"Result: list is empty ");
        }

        static void Main(string[] args)
        {
            new Program(new Data.TeamLeagueProvider()).PreventConsole();
        }
    }
}
