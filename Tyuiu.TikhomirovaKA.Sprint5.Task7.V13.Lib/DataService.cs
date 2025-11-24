using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TikhomirovaKA.Sprint5.Task7.V13.Lib
{
    public class DataService : ISprint5Task7V13
    {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path);
            string newStr = "";
            foreach (char c in str)
            {
                if (!(c >= 'a' && c <= 'z')) newStr += c;
            }
            string file = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V13.txt");
            if (File.Exists(file)) File.Delete(file);
            File.WriteAllText(file, newStr);
            return file;
        }
    }
}
