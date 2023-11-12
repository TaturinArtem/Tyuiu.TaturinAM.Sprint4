using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint4.Task5.V19.Lib;
namespace Tyuiu.TaturinAM.Sprint4.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -4, 3, 6, 5, 5 },
                                          { 3, 4, -4, 6, -4 },
                                          { 6, -4, 6, 4, 5 },
                                          { -5, -4, 4, -4, 5 },
                                          { 3, -5, -6, 4, -6 } };

            int res = ds.Calculate(mas2);
            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}
