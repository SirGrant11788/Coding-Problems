using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Problems
{
    class _2dArray
    {
        static void TwoDArray()
        {
            //10 times table
            int[,] arr = new int[11, 11];//declaration of 2D array 
            String[] sarr = new string[101];//array for table display
            string result = "";//string for table display
            //calc results
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    arr[i, j] = i * j;
                }
            }
            //display results and what has been timesed 
            Console.WriteLine("START 10 times table using a 2d array");
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine(i + "*" + j + " = " + arr[i, j]);
                }
            }
            Console.WriteLine("END 10 times table using a 2d array");
            Console.ReadKey();
            //
            Console.WriteLine("START TABLE 10 times table using a 2d array");
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    result += "\t" + (arr[i, j]).ToString();
                    sarr[i] = result;
                }
                result = "";
                Console.Write(sarr[i] + "\n");
            }
            Console.WriteLine("END TABLE 10 times table using a 2d array");
            Console.ReadKey();


        }
    }
}
