using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DatskiyDE.Sprint6.Task1.V2.Lib;

namespace Tyuiu.DatskiyDE.Sprint6.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Assert.IsNotNull(result);
            Assert.AreEqual(11, result.Length);
        }
    }
}