using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DatskiyDE.Sprint6.Task6.V23.Lib
{
    public class DataService : ISprint6Task6V23
    {
        public string CollectTextFromFile(string path)
        {
            try
            {
                string result = "";

                if (!File.Exists(path))
                {
                    throw new FileNotFoundException("Файл не найден", path);
                }

                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {             
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t' },
                                              StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (word.IndexOf('s', StringComparison.OrdinalIgnoreCase) >= 0 ||
                            word.IndexOf('s', StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            if (!string.IsNullOrEmpty(result))
                            {
                                result += " ";
                            }
                            result += word;
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при обработке файла: " + ex.Message);
            }
        }
    }
}