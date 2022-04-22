//F. Сумма элементов массива

using System;
using System.Linq;
namespace Myprogramm
{
    class Programm
    {
        static int SumElement(int[] arr)
        {
            int Sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Sum += arr[i];
            }
            return Sum;
        }
        private static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int SumElementArray = SumElement(Array);
            Console.WriteLine(SumElementArray);
        }
    }
}