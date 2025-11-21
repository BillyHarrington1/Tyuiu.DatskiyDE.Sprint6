using Tyuiu.DatskiyDE.Sprint6.Task4.V5.Lib;

namespace Tyuiu.DatskiyDE.Sprint6.Task4.V5.Test
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