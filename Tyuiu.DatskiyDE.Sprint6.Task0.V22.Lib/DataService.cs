using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DatskiyDE.Sprint6.Task0.V22.Lib
{
    public class DataService : ISprint6Task0V22
    {
        public double Calculate(int x)
        {
            double dx = x;
            double y = 0.7 * Math.Pow(dx, 3) + 1.52 * Math.Pow(dx, 2);
            y = Math.Round(y, 3);
            return y;
        }
    }
}