using System;
using System.Collections.Generic;
using System.Text;
//the classic game FizzBuzz!
namespace Coding_Problems
{
    class FizzBuzz
    {

        public  void Play()
        {

            Console.WriteLine("Play FizzBuzz!\n(1)User VS PC\n(2)PC VS PC\n(3)Exit");
            int.TryParse(Console.ReadLine(), out int menu);
            
                switch (menu)
                {
                    case 1:
                    UserVsPc();
                        break;
                    case 2:
                        PcVsPC();
                        break;
                    default:
                        Console.WriteLine("Please enter 1 or 2 to select menu option");
                        break;
                }
            
        }

        public static void PcVsPC()
        {
            Console.WriteLine("PC VS PC");
            for (double i = 0; i <= 100; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
                else {
                    if (i % 3 == 0 && i % 5 == 0 && i != 0) 
                    {
                        Console.WriteLine("FizzBuzz " + i);
                    } else {
                        if (i % 3 == 0 && i != 0)
                        {
                            Console.WriteLine("Fizz " + i);
                        }
                        if (i % 5 == 0 && i != 0)
                        {
                            Console.WriteLine("Buzz " + i);
                        }
                    }
                }
            }
            
        }

        public void UserVsPc()
        {
            
            int turns = 0;
            bool mistake = false;
            while(mistake == false)
            {
                turns++;
                string ans = Check(turns);
                Console.Write("Enter Number: ");
                string input = Console.ReadLine();
                if(input.ToLower().Equals(ans.ToLower()))
                {
                    Console.WriteLine($"User Played {input} on number {turns} which is correct!");
                    turns++;
                    Console.WriteLine($"PC Played {Check(turns)} on number {turns} which is correct!");
                }
                else
                {
                    Console.WriteLine($"User Played {input} on number {turns} which is incorrect!");
                    Console.WriteLine("it should have been: "+ans);
                    Console.WriteLine("YOU LOOSE");
                    mistake = true;
                }
            }

        }

        public string Check(int number)
        {
            
                if (number % 3 == 0 && number % 5 == 0)
                {
                    return "FizzBuzz";
                }
                if (number % 3 == 0 )
                {
                    return "Fizz";
                }
                if (number % 5 == 0)
                {
                    return "Buzz";
                }
            return ""+number;
        }

    }
}
