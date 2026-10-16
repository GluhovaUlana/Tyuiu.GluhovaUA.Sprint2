using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint2.Task7.V2;
using Tyuiu.GluhovaUA.Sprint2.Task7.V2.Lib;

namespace Tyuiu.GluhovaUA.Sprint2.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(0.5, 0.1));
            Assert.IsTrue(ds.CheckDotInShadedArea(1, 0));
            Assert.IsFalse(ds.CheckDotInShadedArea(-0.5, 0.5));
            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, 0.8));
            Assert.IsFalse(ds.CheckDotInShadedArea(0.9, 0.9));
        }
    }
}