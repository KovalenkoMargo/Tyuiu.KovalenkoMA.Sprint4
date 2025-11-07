using Tyuiu.KovalenkoMA.Sprint4.Task2.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        Console.Title = "Спринт #4 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #23                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ВВЕДИТЕ ИСХОДНЫЕ ДАННЫЕ:                                                *");
        Console.WriteLine("***************************************************************************");

        int len;
        Console.WriteLine("Введите кол-во элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[len];
        for (int i = 0; i <= len - 1; i++)
        {
            a[i] = rnd.Next(3, 8);
        }

        Console.WriteLine("");
        for (int i =0;  i <= len-1; i++)
        {
            Console.Write(a[i] + "\t");
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(a));

        Console.ReadKey();
    }
}