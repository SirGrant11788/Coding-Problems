using System;

namespace Coding_Problems
{
    class Program
    {
        //Delegate
        public CalcDelagate Subtract { get; internal set; }
        public CalcDelagate Times { get; internal set; }
        public CalcDelagate Divide { get; internal set; }
        //

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of project to run\n" +
                "1 2dArray\n" +
                "2 Array Inserstion Sort\n" +
                "3 Create PDF\n" +
                "4 Delegate\n" +
                "5 Encoded Message\n" +
                "6 Fibonacci\n" +
                "7 FizzBuzz\n" +
                "8 Knight\n" +
                "9 Linked List\n" +
                "10 Linked List Swap\n" +
                "11 List Add Up To K\n" +
                "12 Map Prefix\n" +
                "13 Monte Carlo\n" +
                "14 Palindrome\n" +
                "15 Rearrange\n" +
                "16 Recurring\n" +
                "17 Reverse Return\n" +
                "18 Root Binary Tree\n" +
                "19 Stack vs Queue\n" +
                "20 Time Angle\n" +
                "21 Future Project\n" +
                "22 Future Project\n" +
                "23 Future Project\n" +
                "25 Future Project\n" +
                "26 Future Project\n");
            int.TryParse(Console.ReadLine(), out int menuOption);

            switch (menuOption)
            {
                case 1:
                    _2dArray.TwoDArray();
                    break;
                case 2:
                    ArrayInsertionSort.InsetionSort();
                    break;
                case 3:
                    CreatePDF.PDF();
                    break;
                case 4:
                    Delegate.Delegates();
                    break;
                case 5:
                    EncodedMessage.EncodedMessages();
                    break;
                case 6:
                    Fibonacci.Fibanacci();
                    break;
                case 7:
                    FizzBuzz fizzbuzz = new FizzBuzz();
                    fizzbuzz.Play();
                    break;
                case 8:
                    Knight.Play();
                    break;
                case 9:
                    LinkedList.linkedList();
                    break;
                case 10:
                    LinkedListSwap.Swap();
                    break;
                case 11:
                    ListAddUpToK.AddUpToK();
                    break;
                case 12:
                    MapPrefix.PrefixSum();
                    break;
                case 13:
                    MonteCarlo.MonteCarloPiApproximationSerialSimulation();
                    break;
                case 14:
                    Palindrome.MakePalindrome();
                    break;
                case 15:
                    Rearrange.Adj();
                    break;
                case 16:
                    Recurring.RunRecurring();
                    break;
                case 17:
                    ReverseReturn.RunReverseReturn();
                    break;
                case 18:
                    RootBinaryTree.RunRootTree();
                    break;
                case 19:
                    StackVsQueue.SvsQ();
                    break;
                case 20:
                    TimeAngle.Time();
                    break;
                case 21:

                    break;
                case 22:

                    break;
                case 23:

                    break;
                case 24:

                    break;
                case 25:

                    break;
                case 26:

                    break;
                default:
                    break;
            }

            
        }
    }
}
