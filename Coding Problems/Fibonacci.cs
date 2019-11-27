using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Problems
{
    class Fibonacci
    {
        //Write a method Fib() that takes an integer nn and returns the nnth Fibonacci ↴ number.
        public static void Fibanacci()
        {
            Console.Write("Enter integar n to retrive nth Fibonacci number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Fibonacci f = new Fibonacci();
            Console.WriteLine(n+ "th Fibonacci number (Math): " + f.Fib(n));
            Console.ReadKey();
            Console.WriteLine(n + "th Fibonacci number (Recursion): " + FibRec(n));
        }
        public int Fib(int n)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;
            double fibNo = Math.Round(Math.Pow(phi, n) / Math.Sqrt(5));

            return (int) fibNo;
        }
        //using recursion
        public static int FibRec(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FibRec(n - 1) + FibRec(n - 2);
            }
        }
    }
}
