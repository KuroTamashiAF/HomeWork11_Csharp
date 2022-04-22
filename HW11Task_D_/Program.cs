// D. Наименьшее число

using System;
using System.Linq;
namespace Myprogramm
{
    class Programm
    {
        static int MinElement(int[] arr)
        {
            int Min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }
            }
            return Min;
        }


        private static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int Min = MinElement(Array);
            Console.WriteLine(Min);

        }
    }
}