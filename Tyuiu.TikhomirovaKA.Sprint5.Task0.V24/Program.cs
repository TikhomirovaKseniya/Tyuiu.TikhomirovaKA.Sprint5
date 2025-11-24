using Tyuiu.TikhomirovaKA.Sprint5.Task0.V24.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #5                                                              *");
        Console.WriteLine("* Тема: Обработка файлов                                                 *");
        Console.WriteLine("* Задание #0                                                             *");
        Console.WriteLine("* Вариант #24                                                            *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        int x = 3;
        Console.WriteLine(x);

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Файл создан!");
        Console.ReadKey();
    }
}