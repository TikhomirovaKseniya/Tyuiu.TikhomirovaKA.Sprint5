using Tyuiu.TikhomirovaKA.Sprint5.Task2.V11.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #5                                                              *");
        Console.WriteLine("* Тема: Обработка файлов                                                 *");
        Console.WriteLine("* Задание #2                                                             *");
        Console.WriteLine("* Вариант #11                                                            *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        int[,] matrix = new int[,] { { 4, 9, 3 }, { 5, 8, 8 }, { 5, 7, 5 } };
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + ", ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");
        string res = ds.SaveToFileTextData(matrix);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Файл создан!");
        Console.ReadKey();
    }
}