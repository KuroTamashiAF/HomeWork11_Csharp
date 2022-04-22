// B. Наибольшее произведение  

using System;
using System.Linq;
namespace Myprogramm
{
    class Programm
    {

        private static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Array  = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int FirstMax = Array[0];
            int SecondMax = Array[0];
            int ThirdMax = Array[0];
            for (int i = 1; i < Array.Length; i++)
            {
                if (Math.Abs(Array[i]) > Math.Abs(FirstMax))
                {
                    ThirdMax = SecondMax;
                    SecondMax = FirstMax;
                    FirstMax = Array[i];
                    
                }
                else if((Math.Abs(Array[i]) > Math.Abs(SecondMax)&& Math.Abs(SecondMax)<Math.Abs(FirstMax)))
                {
                    SecondMax= Array[i];
                }
                else if((Math.Abs(Array[i]) > Math.Abs(ThirdMax)&& Math.Abs(ThirdMax)<Math.Abs(SecondMax) &&Math.Abs(ThirdMax)<Math.Abs(FirstMax)))
                {
                    ThirdMax = Array[i];
                }
            }
            Console.WriteLine($"{FirstMax} {SecondMax} {ThirdMax}");  
        }                                                 
    }

}






