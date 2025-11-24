using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TikhomirovaKA.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);   
            double x = double.Parse(strX, CultureInfo.InvariantCulture);
            double res = Math.Round((1/Math.Cos(Convert.ToDouble(x))+2.2*Math.Pow(Convert.ToDouble(x), 2)), 3);            
            return res;
        }
    }
}
