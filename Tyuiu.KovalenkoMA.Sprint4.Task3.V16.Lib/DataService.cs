using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KovalenkoMA.Sprint4.Task3.V16.Lib
{
    public class DataService : ISprint4Task3V16
    {
        public int Calculate(int[,] array)
        {

            int min1 = int.MaxValue;
            for (int i = 0; i< array.GetLength(0); i++)
            {
                for (int j = 0;  j < array.GetLength(1); j++)
                {
                    if (array[i,j] == array[i,4] && array[i,j] < min1)
                    {
                        min1 = array[i,j];
                    }
                }
            }
            return min1;
        }
    }
}
