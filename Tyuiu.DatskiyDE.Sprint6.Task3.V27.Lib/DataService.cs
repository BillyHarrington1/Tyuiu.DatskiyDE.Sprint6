using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DatskiyDE.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Создаём массив пар: (значение в 4-й строке, индекс столбца)
            var valuesAndIndices = new (int value, int colIndex)[cols];

            for (int j = 0; j < cols; j++)
            {
                valuesAndIndices[j] = (matrix[3, j], j);
            }

            // Сортируем столбцы по значению в 4-й строке (индекс 3)
            Array.Sort(valuesAndIndices, (a, b) => a.value.CompareTo(b.value));

            // Создаём результат: переставляем столбцы в новом порядке
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