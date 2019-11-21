using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Problems
{
    public delegate void CalcDelagate(int a, int b);//declare delegate

    class Delegate
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("ADD");
            Console.WriteLine(a + b);

        }
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Subtract");
            Console.WriteLine(a - b);
        }
        public void Divide(int a, int b)
        {
            Console.WriteLine("Divide");
            Console.WriteLine(a / b);
        }
        public void Times(int a, int b)
        {
            Console.WriteLine("Times");
            Console.WriteLine(a * b);
        }
        static void Delegates()
        {
            Program p = new Program();

            //CalcDelagate calcDAdd = new CalcDelagate(p.Add);//instantiat delegate
            //CalcDelagate calcDSub = new CalcDelagate(p.Subtract);
            //CalcDelagate calcDTimes = new CalcDelagate(p.Times);
            //CalcDelagate calcDDivide = new CalcDelagate(p.Subtract);
            //type safe pointer
            // CalcDelagate cld = p.Add;//same as cld += p.Add;
            //cld.Invoke(100, 50);
            //cld += p.Subtract;//operater overloading
            //cld += p.Times;
            //cld += p.Divide;
            //cld(100, 50);

            //lambda
            //CalcDelagate myDelegate = new CalcDelagate(delegate {
            //    Console.WriteLine("This is Caller One lambda function...");
            //});
            //myDelegate(150,50);
            Console.WriteLine("LAMBDA");
            CalcDelagate cldA = (int a, int b) =>
            {
                Console.WriteLine("ss");
            };
            cldA += p.Subtract;//operater overloading
            cldA += p.Times;
            cldA += p.Divide;
            cldA(100, 50);
            //p.Add(100,50);
            //p.Subtract(100, 50);
            //p.Times(100, 50);
            //p.Divide(100, 50);



            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
