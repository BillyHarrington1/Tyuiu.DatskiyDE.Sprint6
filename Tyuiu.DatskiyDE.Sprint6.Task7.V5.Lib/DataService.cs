using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DatskiyDE.Sprint6.Task7.V5.Lib
{
    public class DataService : ISprint6Task7V5
    {
        public int[,] GetMatrix(string path)
        {
         
            string[] lines = File.ReadAllLines(path);

         
            lines = Array.FindAll(lines, l => !string.IsNullOrWhiteSpace(l));

            int rows = lines.Length;
            int cols = lines[0]
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .Length;

            int[,] matrix = new int[rows, cols];

    
            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i]
                    .Trim()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(parts[j].Trim());
                }
            }

      
            int lastCol = cols - 1;

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, lastCol] < 2)
                    matrix[i, lastCol] = 2;
            }

            return matrix;
        }
    }
}
