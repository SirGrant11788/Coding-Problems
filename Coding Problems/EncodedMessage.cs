using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Problems
{
    class EncodedMessage
    {
        //Given the mapping a=1, b=2..z= 26 and an encoded message, count the number of ways it can decoded.
        static void EncodedMessages()
        {
            int decoded = 0;
            string decrypted = null;
            Console.Write("Enter Code: ");
            string encrypted = Console.ReadLine();

            IList<string> list = new List<string>() { ".", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "n", "m", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            //   0   1   2   3   4   5   6   7   8   9   10  11  12   13   14   15   16   17   18   19   20   21   22   23   24   25   26   27   28 
            for (int k = 1; k <= 2; k++)
            {
                for (int j = 0; j <= encrypted.Length - 1; j++)
                {
                    try
                    {
                        decrypted += " " + list[Int32.Parse(encrypted.Substring(j, k))];
                        decoded++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex);//error with loop going over last char finding double char
                    }

                }
            }
            Console.WriteLine("Decrypted: " + decrypted + "\ndecoded ways: " + decoded);
            Console.ReadKey();

        }
    }
}
