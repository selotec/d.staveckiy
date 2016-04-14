using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1. For loops.
            //int N = 0;
            //int sum = 0;
            //int min = 0;
            //int max = 0;
            //int evens_count = 0;
            //int odds_composition = 0;
            //Console.WriteLine("Type N:");
            //N = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < N; i++)
            //{
            //    int current = Convert.ToInt32(Console.ReadLine());
            //    sum += current;
            //    if (current > max)
            //    {
            //        max = current;
            //    }
            //    if (i == 0)
            //    {
            //        min = current;
            //    }
            //    if (current < min)
            //    {
            //        min = current;
            //    }
            //    if (current % 2 == 0)
            //    {
            //        evens_count++;
            //    }
            //    else if (current % 2 == 1)
            //    {
            //        if (odds_composition == 0)
            //        {
            //            odds_composition = 1;
            //        }
            //        odds_composition *= current;
            //    }
            //}
            //Console.WriteLine("Sum: " + sum + "\nMax: " + max + "\nMin: " + min + "\nCount of evens: " + evens_count +
            //    "\nMultiplation of odds: " + odds_composition);

            //Task2. Sort array.
            //int N = 0;
            //int[] numbers;
            //Console.WriteLine("Type N:");
            //N = Convert.ToInt32(Console.ReadLine());
            //numbers = new int[N];
            //for (int i = 0; i < N; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Array.Sort(numbers);
            //Console.WriteLine("Sorted list:");
            //for (int i = 0; i < N; i++)
            //{
            //    string delimeter = ", ";
            //    if (i == N - 1)
            //    {
            //        delimeter = "\n";
            //    }
            //    Console.Write(numbers[i] + delimeter);
            //}  

            //Task3. Matrix
            //int N = 0;
            //int[,] m1;
            //int[,] m2;
            //int[,] result;
            //Random rnd = new Random();

            //Console.WriteLine("Type N:");
            //N = Convert.ToInt32(Console.ReadLine());
            //m1 = new int[N, N];
            //m2 = new int[N, N];
            //result = new int[N, N];
            //Console.WriteLine("\nThe first matrix:");
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        string delimeter = " ";
            //        if (j == N - 1)
            //        {
            //            delimeter = "\n";
            //        }
            //        m1[i, j] = rnd.Next();
            //        Console.Write(m1[i, j] + delimeter);
            //    }
            //}
            //Console.WriteLine("\nThe second matrix:");
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        string delimeter = " ";
            //        if (j == N - 1)
            //        {
            //            delimeter = "\n";
            //        }
            //        m2[i, j] = rnd.Next();
            //        Console.Write(m2[i, j] + delimeter);
            //    }
            //}
            //Console.WriteLine("\nThe result matrix:");
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        string delimeter = " ";
            //        if (j == N - 1)
            //        {
            //            delimeter = "\n";
            //        }
            //        result[i, j] = m1[i, j] + m2[i, j];
            //        Console.Write(result[i, j] + delimeter);
            //    }
            //}

            //Homework
            //Task1
            //int N = 0;
            //int A = 0;
            //int[] numbers;
            //bool found = false;
            //Random rnd = new Random();
            //Console.WriteLine("Type N:");
            //N = Convert.ToInt32(Console.ReadLine());
            //numbers = new int[N];
            //for (int i = 0; i < N; i++)
            //{
            //    numbers[i] = rnd.Next();
            //    Console.Write(numbers[i] + " ");
            //}
            //Console.WriteLine("\nType A:");
            //A = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < N; i++)
            //{
            //    if (numbers[i] == A)
            //    {
            //        Console.WriteLine("\nYes");
            //        found = true;
            //        break;
            //    }
            //}
            //if (!found)
            //{
            //    Console.WriteLine("\nNo");
            //}

            //Task2
            //int N = 0;
            //int M = 0;
            //Random rnd = new Random();
            //int[,] matrix;
            //int[] minimals;
            //Console.WriteLine("Type N:");
            //N = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Type M:");
            //M = Convert.ToInt32(Console.ReadLine());
            //matrix = new int[N, M];
            //minimals = new int[N];
            //Console.WriteLine("\nMatrix:");
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < M; j++)
            //    {
            //        string delimeter = " ";
            //        if (j == M - 1)
            //        {
            //            delimeter = "\n";
            //        }
            //        matrix[i, j] = rnd.Next();
            //        Console.Write(matrix[i, j] + delimeter);
            //    }
            //}
            //for (int i = 0; i < N; i++)
            //{
            //    int min = matrix[i, 0];
            //    for (int j = 0; j < M; j++)
            //    {
            //        if (matrix[i, j] < min)
            //        {
            //            min = matrix[i, j];
            //        }
            //    }
            //    minimals[i] = min;
            //}
            //Array.Sort(minimals);
            //Console.WriteLine("\nSorted list of mins: ");
            //for (int i = 0; i < N; i++)
            //{
            //    string delimeter = " ";
            //    if (i == N - 1)
            //    {
            //        delimeter = "\n";
            //    }
            //    Console.Write(minimals[i] + delimeter);
            //}

            //Task3
            int left = 0;
            int right = 0;
            string operation = " ";
            Console.WriteLine("Type left operand (int32):");
            left = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type operation (+, -, /, *):");
            operation = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Type right operand (int32):");
            right = Convert.ToInt32(Console.ReadLine());
            if (operation != "+" && operation != "-" && operation != "/" && operation != "*")
            {
                Console.WriteLine("Operation should be +, -, / or *");
            }
            Console.WriteLine("Result:");
            if (operation == "+")
            {
                Console.WriteLine(left + right);
            }
            if (operation == "-")
            {
                Console.WriteLine(left - right);
            }
            if (operation == "/")
            {
                if (right == 0)
                {
                    Console.WriteLine("Division by 0");
                }
                else
                {
                    Console.WriteLine(left / right);
                }
            }
            if (operation == "*")
            {
                Console.WriteLine(left * right);
            }
        }
    }
}
