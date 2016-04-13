using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int num1;
            int num2;
            Console.WriteLine("Type the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum:");
            Console.WriteLine(num1 + num2);

            ////Task 2
            //int n;
            //int i;
            //int mask = 1;
            //Console.WriteLine("Type n:");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Type i:");
            //i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("i bit of n:");
            //Console.WriteLine(n >> i & mask);

            //Task 3
            //int n;
            //int mask = 1;
            //Console.WriteLine("Type n:");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("n with nullified last bit:");
            //Console.WriteLine(n >> mask << mask);
        }
    }
}
