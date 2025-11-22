using Tyuiu.DatskiyDE.Sprint6.Task7.V5.Lib;
namespace Tyuiu.DatskiyDE.Sprint6.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidProcessMatrix()
        {
            DataService ds = new DataService();        
            string path = Path.GetTempFileName().Replace(".tmp", ".csv");
            if (File.Exists(path))
            {
                File.Delete(path);
            }

        }
    }
}
