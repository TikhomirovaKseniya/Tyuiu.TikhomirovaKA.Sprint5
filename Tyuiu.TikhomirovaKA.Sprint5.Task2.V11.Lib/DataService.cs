using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TikhomirovaKA.Sprint5.Task2.V11.Lib
{
    public class DataService : ISprint5Task2V11
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.GetTempPath() + Path.Combine("OutPutFileTask2.txt");
            if (File.Exists(path)) File.Delete(path);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0) matrix[i, j] = 0;                    
                }
            }
            int rows = matrix.GetUpperBound(0) + 1; int columns = matrix.Length / rows;
            
            for (int i = 0; i < rows; i++)
            {
                string str = "";
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1) str = str + matrix[i, j] + "; ";
                    else str = str + matrix[i, j];                    
                }
                if (i != rows - 1) File.AppendAllText(path, str + Environment.NewLine);
                else File.AppendAllText(path, str);
            }
            return path;
        }
    }
}
