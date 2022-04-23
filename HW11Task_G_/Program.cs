// G. Линейный поиск


using System;
using System.Linq;
namespace Myprogramm
{
    class Programm
    {
        static int FindElement(int[] arr, int K)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == K)
                {
                    return (i + 1);
                    
                }
            }
            return -1;
        }
        // static void PrintArray(int[] arr)
        // {
        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         Console.Write($"{arr[i]} ");
        //     }
        // }



        private static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int Key = Convert.ToInt32(Console.ReadLine());
            //PrintArray(Array);
            Console.WriteLine();
            int IndexKey = FindElement(Array, Key);
            Console.WriteLine(IndexKey);
        }
    }
}