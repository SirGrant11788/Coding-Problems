using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Problems
{
    //#159 Given a string, return the first recurring character in it, or null if there is no recurring character.
    //For example, given the string "acbbac", return "b". Given the string "abcdef", return null.
    class Recurring
    {
        public static void RunRecurring()
        {
            string given = "acbbac";
            bool exit = false;
            Console.WriteLine("Given word: " + given);
            for (int i = 0; i <= given.Length - 2; i++)
            {
                if (given[i].Equals(given[i + 1]) && exit == false)
                {
                    Console.WriteLine("Recurring first letter: "+given[i]);
                    exit = true;//checks if there is a recurring letter. ends if to show only the first recuring letter
                    i = given.Length - 2;//end loop
                }
            }
            if(exit == false)
            {
                Console.WriteLine("There is no Recurring letter in: " + given);
            }

            Console.ReadKey();
        }
        

    }
}
