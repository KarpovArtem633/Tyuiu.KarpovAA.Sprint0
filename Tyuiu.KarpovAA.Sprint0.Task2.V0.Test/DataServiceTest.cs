using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpovAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KarpovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            var name = "Артём";
            var res = DataService.GetMassage(name);

            Assert.AreEqual("Привет, Артём", res);
        }
    }
}
