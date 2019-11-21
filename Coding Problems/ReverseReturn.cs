using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Problems
{
    //#161 Given a 32-bit integer, return the number with its bits reversed.
    //For example, given the binary number 1111 0000 1111 0000 1111 0000 1111 0000, return 0000 1111 0000 1111 0000 1111 0000 1111.
    class ReverseReturn
    {
        public static void RunReverseReturn()
        {
            string bitVal = "11110000111100001111000011110000";
            char[] charArray = bitVal.ToCharArray();
            Array.Reverse(charArray);
            Console.Write("Given: "+ bitVal +"\nReversed: ");
            Console.Write(charArray);
            Console.ReadKey();
        }
    }
}
