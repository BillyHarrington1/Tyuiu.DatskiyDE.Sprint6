using Tyuiu.DatskiyDE.Sprint6.Task6.V23.Lib;
namespace Tyuiu.DatskiyDE.Sprint6.Task6.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName(); //создать временный 
            try
            {
                string testData = "Ricardo Millos";
                File.WriteAllText(path, testData);

                string wait = "Millos";
                string res = ds.CollectTextFromFile(path);

                Assert.AreEqual(wait, res);
            }
            finally
            {               
                if (File.Exists(path))
                {
                    File.Delete(path); //удалить временный 
                }
            }
        }
    }
}