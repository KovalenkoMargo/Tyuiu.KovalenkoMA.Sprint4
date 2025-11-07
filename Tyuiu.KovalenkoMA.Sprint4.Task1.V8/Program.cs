using Tyuiu.KovalenkoMA.Sprint4.Task1.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ВВЕДИТЕ ИСХОДНЫЕ ДАННЫЕ:                                                *");
        Console.WriteLine("***************************************************************************");

        int len;
        Console.WriteLine("Введите кол-во элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[len];
        for (int i = 0; i <= len-1; i++)
        {
            Console.WriteLine("введите значение" + i + "элемента массива");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(a));

        Console.ReadKey();
    }
}