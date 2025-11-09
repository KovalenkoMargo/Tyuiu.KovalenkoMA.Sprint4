using Tyuiu.KovalenkoMA.Sprint4.Task6.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string[] mas = new string[] { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write(mas[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        var mas2 = ds.Calculate(mas);
 
        for (int i = 0; i < mas2.Length; i++)
        {
            Console.WriteLine(mas2[i]);
        }

        Console.ReadKey();
    }
}