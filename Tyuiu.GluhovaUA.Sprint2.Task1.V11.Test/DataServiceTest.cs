using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint2.Task1.V11;
using Tyuiu.GluhovaUA.Sprint2.Task1.V11.Lib;
namespace Tyuiu.GluhovaUA.Sprint2.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 145;
            int b = 156;
            int c = 142;
            int d = 117;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
