using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passorfail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* double scores, sum, average;
             sum = 0;
             for(int i = 1; i <= 3; i++) 
             { 
                 scores = Convert.ToDouble(Console.ReadLine());
                 sum += scores;
             }
             Console.WriteLine("The sum is: " + sum);
             average = sum / 3;
             Console.WriteLine("The average is: " + average.ToString("N2"));
             if (average >= 75)
                 Console.WriteLine("Remarks: Passed");
             else
                 Console.WriteLine("Remarks: Failed"); */

            int j, i = 5;
            fun1(ref i);
            fun2(out j);
            Console.WriteLine(i + ", " + j);
        }
        public static void fun1(ref int x)
        {
            x = x * x;
        }
        public static void fun2(out int x)
        {
            x = 6;
            x = x * x;
        }
    }
}
