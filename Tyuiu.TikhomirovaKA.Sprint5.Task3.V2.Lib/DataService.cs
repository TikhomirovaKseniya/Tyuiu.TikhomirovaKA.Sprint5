using System.Text.Unicode;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TikhomirovaKA.Sprint5.Task3.V2.Lib
{
    public class DataService : ISprint5Task3V2
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempPath() + Path.Combine("OutPutFileTask3.bin");
            if (File.Exists(path)) File.Delete(path);
            double y = Math.Round((Math.Exp(x)/x), 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate))) 
                writer.Write(BitConverter.GetBytes(y));
            return path;
        }
    }
}
