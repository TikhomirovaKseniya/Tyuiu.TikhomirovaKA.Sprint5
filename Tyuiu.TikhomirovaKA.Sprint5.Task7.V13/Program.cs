using Tyuiu.TikhomirovaKA.Sprint5.Task7.V13.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        string path = Path.Combine("InPutDataFileTask7V13.txt");
        Console.WriteLine(path);

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");
        string res = ds.LoadDataAndSave(path);
        Console.WriteLine("Файл: " + res + " создан.");
        Console.ReadKey();
    }
}