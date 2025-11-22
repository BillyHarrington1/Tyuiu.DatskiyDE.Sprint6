using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DatskiyDE.Sprint6.Task6.V23.Lib
{
    public class DataService : ISprint6Task6V23
    {
        public string CollectTextFromFile(string path)
        {
            try
            {
                StringBuilder result = new StringBuilder();

                if (!File.Exists(path))
                {
                    throw new FileNotFoundException("Файл не найден", path);
                }

                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
              
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '\r', '\n', '(', ')', '[', ']', '{', '}', '"', '\'' },
                    StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                    
                        if (word.Equals("s", StringComparison.OrdinalIgnoreCase))
                        {
                            if (result.Length > 0)
                            {
                                result.Append(" ");
                            }
                            result.Append("s");
                        }
                    }
                }

                return result.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при обработке файла: " + ex.Message);
            }
        }
    }
}