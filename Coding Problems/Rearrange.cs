using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Given a string with repeated characters, rearrange the string so that no two adjacent characters are the same.If this is not possible, return None.


namespace Coding_Problems
{
    class Rearrange
    {

        public static void Adj()
        {
            Console.WriteLine("Enter word to be rearranged:");
            String given = Console.ReadLine();
            //String given = "aaabbc";
            String result = null;
            char[] array = given.ToCharArray();

            //rearrange
            int m = 0;
            for (int i = 0; i <= array.Length - 2; i++)
            {
                if (array[i].Equals(array[i + 1]))
                {
                        char temp1 = array[i + 1];
                        
                    for (int n = m; n <= array.Length - 1; n++)
                    {
                        if (!array[i].Equals(given[n]))
                        {
                            array[i + 1] = (given[n]);
                            array[n] = temp1;
                            n = array.Length - 1;
                            m = n;
                        }
                    }
                }
            }

            foreach (char ch in array)
            {
                result += (ch);
            }
            
            //check(result);
            Console.WriteLine(given + " rearranged " + check(result));
            Console.ReadKey();
        }

        static String check(String result)
        {
            String output="";
            for (int i = 0; i <= result.Length - 2; i++)
            {
                if (!result[i].Equals(result[i + 1]))
                {
                    output = result;
                }
                else
                {
                    return "None";
                }
            }

            return output;
        }

    }
}
