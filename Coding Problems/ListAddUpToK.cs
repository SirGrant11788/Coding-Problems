using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Problems
{
    class ListAddUpToK
    {
        public static void AddUpToK()
        {
            int k = 17;
            int[] arr = { 10, 15, 3, 7 };
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = 1; j <= arr.Length - 1; j++)
                {
                    if (arr[i] + arr[j] == k)
                    {
                        Console.WriteLine(arr[i] + " + " + arr[j] + " = " + k);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
