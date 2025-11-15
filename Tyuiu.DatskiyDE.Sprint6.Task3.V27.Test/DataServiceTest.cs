using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DatskiyDE.Sprint6.Task3.V27.Lib;

namespace Tyuiu.DatskiyDE.Sprint6.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSortMatrixByColumn()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                {9, 13, -14, 23, 1},
                {15, -17, 21, 25, 23},
                {-4, 29, -20, -10, 14},
                {27, 33, 12, 33, -12},
                {18, -9, -5, 6, 3}
            };

            int[,] result = ds.Calculate(matrix);

        
            Assert.AreEqual(-10, result[0, 3]);
            Assert.AreEqual(6, result[1, 3]);
            Assert.AreEqual(23, result[2, 3]);
            Assert.AreEqual(25, result[3, 3]);
            Assert.AreEqual(33, result[4, 3]);
        }
    }
}