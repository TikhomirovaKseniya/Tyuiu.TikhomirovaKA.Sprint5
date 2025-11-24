using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.TikhomirovaKA.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            string[] numbers = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int minNumber = int.MinValue;
            foreach (string numberStr in numbers)
            {
                double number = double.Parse(numberStr, CultureInfo.InvariantCulture);
                if (number == Math.Truncate(number) && number % 3 == 0)
                {
                    int intNumber = (int)number;
                    if (intNumber > minNumber)
                    {
                        minNumber = intNumber;
                    }
                }
            }
            if (minNumber == int.MinValue)
                return 0;
            long factorial = 1;
            for (int i = 2; i <= minNumber; i++)
            {
                factorial *= i;
            }
            double res = Math.Round((double)factorial, 3);
            return res;
        }
    }
}
