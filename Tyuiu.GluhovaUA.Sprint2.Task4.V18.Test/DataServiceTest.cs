using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint2.Task4.V18;
using Tyuiu.GluhovaUA.Sprint2.Task4.V18.Lib;
namespace Tyuiu.GluhovaUA.Sprint2.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate1()
        {
            DataService ds = new DataService();
            double x =1;
            double y = 6;
            double res = ds.Calculate(x,y);
            double wait = 6.000;
            Assert.AreEqual(wait, res);
        }
        public void Calculate2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 21.500;
            Assert.AreEqual(wait, res);
        }
    }
}

