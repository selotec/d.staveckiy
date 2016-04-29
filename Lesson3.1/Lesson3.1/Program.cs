using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._1
{
    class Program
    {
        public static int ReadIntFromConsole()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double ReadDoubleFromConsole()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        public static void PrintInt(int number)
        {
            Console.WriteLine($"{number}");
        }

        public static void PrintDouble(double number)
        {
            Console.WriteLine($"{number}");
        }

        public static void PrintIntArray(int[] array)
        {
            string delimeter = " ";
            int length = array.Length;
            for (int i=0; i < length; i++)
            {
                if (i == length)
                {
                    delimeter = Environment.NewLine;
                }
                Console.Write($"{array[i]}{delimeter}");
            }
            Console.WriteLine();
        }

        public static void PrintDoubleArray(double[] array)
        {
            string delimeter = " ";
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                if (i == length)
                {
                    delimeter = Environment.NewLine;
                }
                Console.Write($"{array[i]}{delimeter}");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int length;
            int integer;
            double rational;
            int[] integers;
            double[] doubles;
            Console.WriteLine("Type integer:");
            integer = ReadIntFromConsole();
            Console.WriteLine("Your integer:");
            PrintInt(integer);
            Console.WriteLine("Type double:");
            rational = ReadDoubleFromConsole();
            Console.WriteLine("Your double:");
            PrintDouble(rational);
            Console.WriteLine("Type array's length:");
            length = ReadIntFromConsole();
            integers = new int[length];
            doubles = new double[length];
            for (int i=0; i < length; i++)
            {
                integers[i] = ReadIntFromConsole();
            }
            for (int i = 0; i < length; i++)
            {
                doubles[i] = ReadDoubleFromConsole();
            }
            Console.WriteLine("Your integers array:");
            PrintIntArray(integers);
            Console.WriteLine("Your doubles array:");
            PrintDoubleArray(doubles);
        }
    }
}
