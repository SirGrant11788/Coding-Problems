using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Problems
{
    //Daily Coding Problems #121
    //Given a string which we can delete at most k, return whether you can make a palindrome.
    //For example, given 'waterrfetawx' and a k of 2, you could delete f and x to get 'waterretaw'.
    class Palindrome
    {
        public static void MakePalindrome()
        {
            string txt = "waterrfetawx";//waterrfetawx
            int k = 2;
            Console.WriteLine("word: " + txt + "\nk value: " + k);
            for (int i = 0; txt.Length / 2 - 1 >= i; i++)
            {
                if (txt[txt.Length - 1 - i].Equals(txt[i + 1]))
                {
                    txt = txt.Remove(i, 1);
                    k--;
                }
                if (txt[i].Equals(txt[txt.Length - 1 - i - 1]))
                {
                    txt = txt.Remove(txt.Length - 1 - i, 1);
                    k--;
                }
                if (k < 0)
                {
                    Console.WriteLine(txt);
                    Console.WriteLine("is not a palindrome");
                    Console.WriteLine("k value reached 0");
                    Console.ReadKey();
                }
                if (txt[i].Equals(txt[txt.Length - 1 - i]))
                {
                    int txtSizeHalf = txt.Length / 2;
                    string txt2Rev = null;
                    string txt1 = txt.Substring(0, txtSizeHalf);
                    string txt2 = txt.Substring(txtSizeHalf);
                    while (txtSizeHalf - 1 >= 0)
                    {
                        txt2Rev = txt2Rev + txt2[txtSizeHalf - 1];
                        txtSizeHalf--;
                    }
                    if (i == txt.Length / 2 - 1 && k > 0 || txt1.Equals(txt2Rev))
                    {
                        Console.WriteLine(txt);
                        Console.WriteLine("is a palindrome");
                        Console.WriteLine("k value reached " + k);
                        Console.ReadKey();
                        if (txt1.Equals(txt2Rev)) { i = txt.Length / 2; }//exit for rev compare
                    }
                    if (i == txt.Length / 2 - 1 && i != txt.Length / 2 - 1 && k > 0)
                    {
                        Console.WriteLine(txt);
                        Console.WriteLine("is not a palindrome");
                        Console.WriteLine("k value reached " + k);
                        Console.ReadKey();
                    }
                    //if (0 <= txt.Length - 1 - i)
                    //{
                    //    Console.WriteLine("exit");
                    //    Console.ReadKey();
                    //    i = txt.Length;//stop loop
                    //}

                }
            }
        }
    }
}

