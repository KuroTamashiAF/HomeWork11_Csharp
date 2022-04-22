// A. Чётные на чётных

using System;
using System.Linq;
namespace Myprogramm
{
    class Programm
    {
        static int EvenOnEven(int[] arr)
        {
            int cout = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i + 1) % 2 == 0 && arr[i] % 2 == 0)     // судя по входным данным примера надо брать i+1.
                {                                           // по второму примеру.
                    cout++;
                }
            }
            return cout;
        }
        private static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int Quantity = EvenOnEven(array);
            Console.WriteLine(Quantity);

        }
    }
}