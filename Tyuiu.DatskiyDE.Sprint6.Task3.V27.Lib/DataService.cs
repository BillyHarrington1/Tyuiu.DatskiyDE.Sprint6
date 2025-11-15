using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DatskiyDE.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (cols < 4)
            {
                throw new ArgumentException("Матрица должна иметь как минимум 4 столбца");
            }

            // Создаем копию исходной матрицы
            int[,] resultMatrix = (int[,])matrix.Clone();

            // Сортируем только 4-й столбец (индекс 3), оставляя остальные элементы на своих местах
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (resultMatrix[j, 3] > resultMatrix[j + 1, 3])
                    {
                        // Меняем местами только элементы в 4-м столбце
                        int temp = resultMatrix[j, 3];
                        resultMatrix[j, 3] = resultMatrix[j + 1, 3];
                        resultMatrix[j + 1, 3] = temp;
                    }
                }
            }

            return resultMatrix;
        }
    }
}