using Tyuiu.DatskiyDE.Sprint6.Task0.V22.Lib;

namespace Tyuiu.DatskiyDE.Sprint6.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int x = 2;
            double result = ds.Calculate(x);
            double expected = 11.680;

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}