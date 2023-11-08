﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint4.Task4.V19.Lib;
namespace Tyuiu.TaturinAM.Sprint4.Task4.V19.Task
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 4, 4, 2, 6, 6 },
                                          { 5, 4, 4, 4, 7 },
                                          { 6, 5, 6, 7, 2 },
                                          { 7, 7, 6, 7, 2 },
                                          { 2, 5, 2, 5, 7 } };

            int res = ds.Calculate(mas2);
            int wait = 62;

            Assert.AreEqual(wait, res);
        }
    }
}
