using lab2_partOne.Entities;
using lab2_partOne.Entities.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab.Tests.WeatherParserTests
{
    [TestClass]
    public class WeatherParserTests
    {
        private static readonly Weather _9th = new Weather
        {
            Dy = "10",
            Mxt = 84,
            MnT = 64,
            AvT = 74,
            HDDay = null,
            AvDP = 57.5m,
            HrP = "",
            TPcpn = 0,
            WxType = WxType.F,
            PDir = "210",
            AvSp = 6.6m,
            Dir = "050",
            MxS = 9,
            SkyC = 3.4m,
            MxR = 84,
            MnR = 40,
            AvSLP = 1019m
        };

        [TestMethod]
        public void TestParse()
        {
            var items = new lab2_partOne.Program(new lab2_partOne.Data.WeatherProvider()).Items;

            Assert.AreEqual(31, items.Count);

            Assert.AreEqual(_9th.Dy, items[9].Dy);
            Assert.AreEqual(_9th.MnT, items[9].MnT);
            Assert.AreEqual(_9th.AvT, items[9].AvT);
            Assert.AreEqual(_9th.HDDay, items[9].HDDay);
            Assert.AreEqual(_9th.AvDP, items[9].AvDP);
            Assert.AreEqual(_9th.HrP, items[9].HrP);
            Assert.AreEqual(_9th.TPcpn, items[9].TPcpn);
            Assert.AreEqual(_9th.WxType, items[9].WxType);
            Assert.AreEqual(_9th.PDir, items[9].PDir);
            Assert.AreEqual(_9th.AvSp, items[9].AvSp);
            Assert.AreEqual(_9th.Dir, items[9].Dir);
            Assert.AreEqual(_9th.MxS, items[9].MxS);
            Assert.AreEqual(_9th.SkyC, items[9].SkyC);
            Assert.AreEqual(_9th.MxR, items[9].MxR);
            Assert.AreEqual(_9th.MnR, items[9].MnR);
            Assert.AreEqual(_9th.AvSLP, items[9].AvSLP);
            Assert.AreEqual(_9th.Mxt, items[9].Mxt);
        }
    }
}
