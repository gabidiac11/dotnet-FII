using Helpers.DataExtractor;
using lab2_partOne.Data.Core;
using lab2_partOne.Data.Parser;
using lab2_partOne.Entities;
using System.Collections.Generic;

namespace lab2_partOne.Data
{
    public class WeatherProvider : Provider<Weather>
    {
        public WeatherProvider()
        {
            Parser = new WeatherParser();
            Source = "C:/Users/Gabi/source/repos/lab1/lab2/Data/Files/weather.dat";
        }
    }
}
