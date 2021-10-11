using Helpers.DataExtractor;
using lab2_partOne.Data.Core;
using lab2_partOne.Data.Parser;
using lab2_partOne.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace lab2_partOne.Data
{
    public class WeatherProvider : Provider<Weather>
    {
        public WeatherProvider()
        {
            Parser = new WeatherParser();
            Source = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Files\", "weather.dat");
        }
    }
}
