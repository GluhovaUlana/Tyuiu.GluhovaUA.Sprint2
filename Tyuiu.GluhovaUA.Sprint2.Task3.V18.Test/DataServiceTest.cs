using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint2.Task3.V18;
using Tyuiu.GluhovaUA.Sprint2.Task3.V18.Lib;
namespace Tyuiu.GluhovaUA.Sprint2.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double res = ds.Calculate(x);
            double wait = 36.0;
            Assert.AreEqual(wait, res);

        }
        public void Calculate2()
        { 
            DataService ds = new DataService();
            double x = 0.0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res); ;

        }
        public void Calculate3()
        {
            DataService ds = new DataService();
            double x = -5.0;
            double res = ds.Calculate(x);
            double wait = 0.822;
            Assert.AreEqual(wait, res);

        }
        public void Calculate4()
        {
            DataService ds = new DataService();
            double x = -23;
            double res = ds.Calculate(x);
            double wait = -252.957;
            Assert.AreEqual(wait, res);

        }
    }
}
