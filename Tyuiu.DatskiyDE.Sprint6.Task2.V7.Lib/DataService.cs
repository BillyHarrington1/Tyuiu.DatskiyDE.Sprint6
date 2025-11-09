using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DatskiyDE.Sprint6.Task2.V7.Lib
{
    public class DataService : ISprint6Task2V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = 0.0;

                double denominator = Math.Cos(x) + 1;

                if (denominator == 0)
                {
                    fx = 0.0;
                }
                else
                {
                    fx = 3.0 * x + 2.0 - (2.0 * x - x) / denominator;
                }

                fx = Math.Round(fx, 2);
                result[index] = fx;
                index++;
            }

            return result;
        }
    }
}