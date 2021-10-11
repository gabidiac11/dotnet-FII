using lab2_partOne.Data.Core;
using lab2_partOne.Data.Core.Interfaces;
using lab2_partOne.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2_partOne
{
    public class Program : Instance<Weather>
    {
        public Program(IProvider<Weather> provider) : base(provider) { }

        public override void PrintResult(Weather result)
        {
            if (result != null)
            {
                Console.WriteLine($"Result: Day with lowest difference between min-max temperature is {(string)result.GetIndicator()}, of value {result.GetDifferenceBetweenTargetProperties()} ");
                return;
            }
            
            Console.WriteLine($"Result: list is empty ");
        }

        static void Main(string[] args)
        {
            new Program(new Data.WeatherProvider()).PreventConsole();
        }
    }
}