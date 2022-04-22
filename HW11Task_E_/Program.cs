// E. Наибольшее число

using System;
using System.Linq;
namespace Myprogramm
{
    class Programm
    {
        static int MaxElement(int[] arr)
        {
            int Max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
            }
            return Max;
        }


        private static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int Max = MaxElement(Array);
            Console.WriteLine(Max);

        }
    }
}