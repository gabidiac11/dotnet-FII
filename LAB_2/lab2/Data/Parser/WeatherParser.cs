using lab2_partOne.Entities;
using System;
using System.Collections.Generic;
using Helpers.Parser.ParserExtensions;
using lab2_partOne.Entities.Enums;
using lab2_partOne.Data.Core.Interfaces;
using System.Linq;
using lab2.Data.Core;

namespace lab2_partOne.Data.Parser
{
    public class WeatherParser : EntityParser<Weather>
    {

        public override Weather ParseEntity(List<string> values)
        {
            if (values.Count != 17)
            {
                throw new Exception("Invalid values: Length");
            }
      
            return new Weather
            {
                Dy = values[0],
                Mxt = values[1].ToDecimal(),
                MnT = values[2].ToDecimal(),
                AvT = values[3].ToDecimal(),
                HDDay = (int?)values[4].ToDecimalOrDefault(),
                AvDP = values[5].ToDecimal(),
                HrP = values[6],
                TPcpn = values[7].ToDecimal(),
                WxType = (WxType?)values[8].ParseToEnum(typeof(WxType)),
                PDir = values[9],
                AvSp = values[10].ToDecimal(),
                Dir = values[11],
                MxS = (int)values[12].ToDecimal(),
                SkyC = values[13].ToDecimal(),
                MxR = (int?)values[14].ToDecimalOrDefault(),
                MnR = (int?)values[15].ToDecimalOrDefault(),
                AvSLP = values[16].ToDecimalOrDefault()
            };
        }
    }
}
