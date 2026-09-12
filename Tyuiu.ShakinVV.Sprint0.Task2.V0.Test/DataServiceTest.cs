using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShakinVV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ShakinVV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Вовчик";
            var res = DataService.GetMessage(name);
            
            Assert.AreEqual("Привет..., Вовчик", res);
        }
    }
}
