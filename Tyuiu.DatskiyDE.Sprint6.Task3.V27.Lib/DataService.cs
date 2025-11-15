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

            // Извлекаем 4-й столбец (индекс 3) и сортируем его
            int[] column3 = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                column3[i] = matrix[i, 3];
            }

            Array.Sort(column3); // теперь column3 отсортирован         
            return result;
        }
    }
}