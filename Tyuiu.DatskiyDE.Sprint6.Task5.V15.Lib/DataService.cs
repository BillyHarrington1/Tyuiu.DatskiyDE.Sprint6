using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DatskiyDE.Sprint6.Task5.V15.Lib
{
    public class DataService : ISprint6Task5V15
    {   
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            List<double> numbers = new List<double>();

            foreach (var line in File.ReadLines(path))
            {
                if (double.TryParse(line, out double value))
                {
                    numbers.Add(Math.Round(value, 3));
                }
            }
            return numbers.ToArray();
        }

        public object LoadFromFile_DDE(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
