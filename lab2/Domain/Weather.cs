using lab2_partOne.Data.Core.Interfaces;
using lab2_partOne.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_partOne.Entities
{
    public class Weather : IEntity
    {
        public string Dy { get; set; }
        public decimal Mxt { get; set; }
        public decimal MnT { get; set; }
        public decimal AvT { get; set; }
        public int? HDDay {get; set;}
        public decimal AvDP {get; set;}
        public string HrP {get; set;}
        public decimal TPcpn {get; set;}
        public WxType? WxType {get; set;}
        public string PDir {get; set;}
        public decimal AvSp {get; set;}
        public string Dir {get; set;}
        public int MxS {get; set;}
        public decimal SkyC {get; set;}
        public int? MxR {get; set;}
        public int? MnR {get; set;}
        public decimal? AvSLP{get; set;}

        public decimal GetDifferenceBetweenTargetProperties()
        {
            return Math.Abs(Mxt - MnT);
        }

        public object GetIndicator()
        {
            return Dy;
        }
    }
}
