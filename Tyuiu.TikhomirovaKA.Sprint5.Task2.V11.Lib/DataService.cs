using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TikhomirovaKA.Sprint5.Task2.V11.Lib
{
    public class DataService : ISprint5Task2V11
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.GetTempPath() + Path.Combine("OutPutFileTask2.txt");
            if (File.Exists(path)) File.Delete(path);
            
            return path;
        }
    }
}
