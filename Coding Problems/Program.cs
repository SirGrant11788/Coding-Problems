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
            Rearrange.Adj();
        }
    }
}
