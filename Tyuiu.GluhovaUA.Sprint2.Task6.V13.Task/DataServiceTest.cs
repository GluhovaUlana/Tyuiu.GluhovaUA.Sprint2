using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint2.Task6.V13;
using Tyuiu.GluhovaUA.Sprint2.Task6.V13.Lib;
namespace Tyuiu.GluhovaUA.Sprint2.Task6.V13.Task
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDateOfNextDay()
        {
            DataService ds = new DataService();
            string result1 = ds.FindDateOfNextDay(2024, 3, 15);
            Assert.AreEqual("16.03.2024", result1);
            string result2 = ds.FindDateOfNextDay(2024, 4, 30);
            Assert.AreEqual("01.05.2024", result2);
            string result3 = ds.FindDateOfNextDay(2024, 12, 31);
            Assert.AreEqual("01.01.2025", result3);
            string result4 = ds.FindDateOfNextDay(2024, 2, 28);
            Assert.AreEqual("29.02.2024", result4);
            string result5 = ds.FindDateOfNextDay(2024, 2, 29);
            Assert.AreEqual("01.03.2024", result5);
        }

        [TestMethod]
        public void FindDateOfNextDay_InvalidDate()
        {
            DataService ds = new DataService();
            Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfNextDay(2024, 13, 1));
            Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfNextDay(2024, 1, 32));
        }
    }
}
