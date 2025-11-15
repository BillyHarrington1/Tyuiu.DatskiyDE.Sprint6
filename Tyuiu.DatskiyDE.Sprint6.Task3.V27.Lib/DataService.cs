using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DatskiyDE.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 3)
                        result[i, j] = matrix[i, 4]; // 3-й столбец = 4-й столбец
                    else if (j == 4)
                        result[i, j] = matrix[i, 3]; // 4-й столбец = 3-й столбец
                    else
                        result[i, j] = matrix[i, j]; // остальные столбцы без изменений
                }
            }

            return result;
        }
    }
}