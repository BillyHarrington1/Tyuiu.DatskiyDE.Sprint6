using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DatskiyDE.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

     
            var colsWithKey = new (int[] col, int key)[cols];

            for (int j = 0; j < cols; j++)
            {
                int[] col = new int[rows];
                for (int i = 0; i < rows; i++)
                {
                    col[i] = matrix[i, j];
                }
                colsWithKey[j] = (col, matrix[3, j]); 
            }
    
            Array.Sort(colsWithKey, (a, b) => a.key.CompareTo(b.key));

       
            int[,] result = new int[rows, cols];
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    result[i, j] = colsWithKey[j].col[i];
                }
            }

            return result;
        }
    }
}