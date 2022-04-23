// D. Ваня и книги 


using System;
using System.Linq;
namespace Myprogramm
{
    class Programm
    {
        static void FiilArray(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
        }
        // static void PrintArray(int[] arr)
        // {
        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         Console.Write($"{arr[i]} ");
        //     }
        // }
        static int NumberOfDigits(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];
                while (number > 0)
                {
                    number /= 10;
                    count++;
                }
            }
            return count;
        }

        private static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            FiilArray(array);
            //PrintArray(array);
            int CountOfDigit = NumberOfDigits(array);
            Console.WriteLine(CountOfDigit);

        }
    }
}











