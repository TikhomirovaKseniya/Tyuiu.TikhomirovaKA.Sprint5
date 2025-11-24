using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.Tikhomirova.Sprint5.Task1.V16.Lib
{
    public class DataService : ISprint5Task1V16
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempPath() + Path.Combine("OutPutFileTask1.txt");
            if (File.Exists(path)) File.Delete(path);
            startValue = -5;
            stopValue = 5;
            for (double x = startValue; x <= stopValue; x++)
            {
                double fx = Math.Round((Math.Sin(x) + (2 * x) / 3 - Math.Cos(x) * 4 * x), 2);
                if (double.IsInfinity(fx) || double.IsNaN(fx))
                {
                    fx = 0;
                }
                if (x != stopValue) File.AppendAllText(path, Convert.ToString(fx) + Environment.NewLine);
                else File.AppendAllText(path, Convert.ToString(fx));
            }            
            return path;
        }
    }
}
