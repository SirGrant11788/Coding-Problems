using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given a linked list, remove all consecutive nodes that sum to zero.Print out the remaining nodes.
//For example, suppose you are given the input 3 -> 4 -> -7 -> 5 -> -6 -> 6. In this case, you should first remove 3 -> 4 -> -7, then -6 -> 6, leaving only 5.
namespace Coding_Problems
{
    class LinkedList
    {
        public static void linkedList()
        {
            LinkedList<int> my_list = new LinkedList<int>();
            AddToList(my_list);
            //display given list
            foreach (int num in my_list)
            {
                Console.Write(num + " > ");
            }
            Console.ReadKey();
            //Sum and Check
            CheckSum(my_list);

        }

        static void CheckSum(LinkedList<int> my_list)
        {
            int sum = 0, temp = 0;
            LinkedList<int> my_temp_list = new LinkedList<int>();

            foreach (int num in my_list)
            {
                temp++;
                //sum = num + sum;
                sum += num;
                Console.Write("\nsum: " + sum + " temp =" + temp + " num: " + num);
                if (sum == 0)
                {
                    sum = 0;
                    //my_temp_list.RemoveFirst();

                    // my_temp_list.Remove(my_temp_list.First.Next.Value);
                    my_temp_list.Clear();
                    Console.WriteLine(" CLEAR ");
                }
                else
                {
                    my_temp_list.AddLast(num);
                    Console.WriteLine(" ADD: " + num);

                }
            }
            temp = 0;
            sum = 0;
            foreach (int numb in my_temp_list.Reverse())
            {

                temp++;
                //sum = num + sum;
                sum += numb;
                Console.Write("\nsum: " + sum + " temp =" + temp + " num: " + numb);
                if (sum == 0)
                {
                    sum = 0;
                    //my_temp_list.RemoveFirst();

                    // my_temp_list.Remove(my_temp_list.First.Next.Value);
                    my_temp_list.Clear();
                    Console.WriteLine(" CLEAR ");
                }
                else
                {
                    my_temp_list.AddLast(numb);
                    Console.WriteLine(" ADD: " + numb);

                }
            }



            Console.WriteLine();
            foreach (int numb in my_temp_list)
            {
                Console.Write(numb + " > ");
            }
            Console.ReadKey();
            //my_list = my_temp_list;
            //return my_list;
        }

        static LinkedList<int> AddToList(LinkedList<int> my_list)
        {
            my_list.AddLast(3);
            my_list.AddLast(4);
            my_list.AddLast(-7);
            my_list.AddLast(5);
            my_list.AddLast(-6);
            my_list.AddLast(6);
            return my_list;
        }
    }
}
