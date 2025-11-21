using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DatskiyDE.Sprint6.Task4.V5.Lib
{
    public class DataService : ISprint6Task4V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = 0.0;

                double denominator = 3.0 * x + 1.2;

                if (denominator == 0)
                {
                    fx = 0.0;
                }
                else
                {
                    fx = (2.0 * Math.Sin(x)) / denominator + Math.Cos(x) - 7.0 * x * 2.0;
                }

                fx = Math.Round(fx, 2);
                result[index] = fx;
                index++;
            }

            return result;
        }
    }
}