using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TikhomirovaKA.Sprint5.Task0.V24.Lib
{
    public class DataService : ISprint5Task0V24
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempPath() + Path.Combine("OutPutFileTask0.txt");
            x = 3;
            double y = Math.Round((Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2)), 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
