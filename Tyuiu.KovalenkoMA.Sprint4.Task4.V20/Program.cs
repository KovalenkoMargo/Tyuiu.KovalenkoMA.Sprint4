using Tyuiu.KovalenkoMA.Sprint4.Task4.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        int[,] matrix = new int[5, 5] { { 4, 5, 5, 6, 4 }, { 7, 8, 4, 7, 5 }, { 5, 6, 5, 8, 5 }, { 7, 5, 8, 7, 8 }, { 4, 7, 7, 8, 8 } };

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j]  + "\t");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        var res = ds.Calculate(matrix);

        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(res[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}