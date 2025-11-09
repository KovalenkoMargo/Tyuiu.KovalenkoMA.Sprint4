using Tyuiu.KovalenkoMA.Sprint4.Task5.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        Console.Title = "Спринт #4 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #21                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ВВЕДИТЕ ИСХОДНЫЕ ДАННЫЕ:                                                *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите кол-во строк : ");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов : ");
        int c = Convert.ToInt32(Console.ReadLine());

        int[,] a = new int[r, c];
        for (int i = 0; i < r ; i++)
        {
            for (int j = 0; j < c; j++)
            {
                a[i,j] = rnd.Next(-8, 2);
            }
        }

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        var res = ds.Calculate(a);

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(res[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}