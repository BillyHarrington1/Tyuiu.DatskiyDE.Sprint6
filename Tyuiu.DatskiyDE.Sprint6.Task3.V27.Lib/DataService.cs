using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DatskiyDE.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[] column3 = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                column3[i] = matrix[i, 3];
            }

            Array.Sort(column3); 
      
            var valuesAndIndices = new (int value, int colIndex)[cols];

            for (int j = 0; j < cols; j++)
            {
                valuesAndIndices[j] = (matrix[3, j], j);
            }
        
            Array.Sort(valuesAndIndices, (a, b) => a.value.CompareTo(b.value));
       
            int[,] result = new int[rows, cols];

            for (int j = 0; j < cols; j++)
            {
                int sourceColIndex = valuesAndIndices[j].colIndex;
                for (int i = 0; i < rows; i++)
                {
                    result[i, j] = matrix[i, sourceColIndex];
                }
            }

            return result;
        }
    }
}