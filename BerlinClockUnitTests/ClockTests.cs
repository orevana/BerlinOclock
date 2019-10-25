using System;
using BerlinClock.Classes;
using BerlinClock.Classes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BerlinClockUnitTests
{
    [TestClass]
    public class ClockTests
    {
        private IClock sku;

        [TestInitialize]
        public void Initiallize()
        {
            sku = new Clock();
        }

      

        [TestMethod]
        public void TestsIfSetTimeCanParseMidninght24()
        {
            sku.SetTime("24:00:00");
            var result = sku.ToString();
            Assert.IsNotNull(result);
            Assert.IsFalse(result == string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "2400:00 Invalid date format")]
        public void TestsIfSetTimeThrowsException()
        {
            sku.SetTime("2400:00");
        }
        [TestMethod]
        public void TestsIfSetTimeCanParseValidTime()
        {
            sku.SetTime(DateTime.Now.ToString());
            var result = sku.ToString();
            Assert.IsNotNull(result);
            Assert.IsFalse(result == string.Empty);
        }

       
    }
}
