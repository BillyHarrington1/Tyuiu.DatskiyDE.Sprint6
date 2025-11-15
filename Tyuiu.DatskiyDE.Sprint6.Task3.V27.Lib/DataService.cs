using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DatskiyDE.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            var rowsWithKey = new (int[] row, int key)[rows];

            for (int i = 0; i < rows; i++)
            {
                int[] row = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    row[j] = matrix[i, j];
                }
                rowsWithKey[i] = (row, matrix[i, 3]); 
            }

            Array.Sort(rowsWithKey, (a, b) => a.key.CompareTo(b.key));
    
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = rowsWithKey[i].row[j];
                }
            }

            return result;
        }
    }
}