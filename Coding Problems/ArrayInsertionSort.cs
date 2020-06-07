using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Problems
{
    //Expected input and output of the Insertion Sort
    //Initial array is: -11 12 -42 0 1 90 68 6 -9
    //Sorted Array is: -42 -11 -9 0 1 6 12 68 90
    //At each iteration, insertion sort removes one element from the input data, finds the location it belongs within the sorted list, and inserts it there.It repeats until no input elements remain.

    class ArrayInsertionSort
    {
        public static void InsetionSort() 
        {
            //insert data in array
            int[] arr = new int[9] { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            int n = 9, i, j, val, flag;
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            //sort algorithm
            //elements are transferred one at a time to the right position.
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    //each element in the array is checked with the previous elements
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            // simple to implement and is quite efficient for small sets of data, especially if it is substantially sorted
            // low overhead and can sort the list as it receives data
            //only a constant amount of memory space for the whole operation
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
// insertion sort is less efficient on larger data sets and less efficient than the heap sort or quick sort algorithms.
