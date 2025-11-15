using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DatskiyDE.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Проверяем, что матрица имеет достаточно столбцов
            if (cols < 4)
            {
                throw new ArgumentException("Матрица должна иметь как минимум 4 столбца");
            }

            // Создаем копию исходной матрицы
            int[,] resultMatrix = (int[,])matrix.Clone();

            // Сортируем 4-й столбец (индекс 3) по возрастанию
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (resultMatrix[j, 3] > resultMatrix[j + 1, 3])
                    {
                        // Меняем местами элементы в 4-м столбце
                        int temp = resultMatrix[j, 3];
                        resultMatrix[j, 3] = resultMatrix[j + 1, 3];
                        resultMatrix[j + 1, 3] = temp;

                        // Также меняем соответствующие строки, чтобы сохранить целостность данных
                        for (int k = 0; k < cols; k++)
                        {
                            if (k != 3) // Не трогаем 4-й столбец, так как мы его уже поменяли
                            {
                                int tempRow = resultMatrix[j, k];
                                resultMatrix[j, k] = resultMatrix[j + 1, k];
                                resultMatrix[j + 1, k] = tempRow;
                            }
                        }
                    }
                }
            }

            return resultMatrix;
        }
    }
}