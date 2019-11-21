using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems
{
    class StackVsQueue
    {
        public static void SvsQ()
        {
            //STACK
            Console.WriteLine("STACK\n");
            Stack st = new Stack();

            st.Push('A');
            st.Push('B');
            st.Push('C');
            st.Push('D');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            st.Push('P');
            st.Push('Q');
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");

            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing values....");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.ReadKey();
            Console.WriteLine("\nQUEUE\n");
            //QUEUE
            Queue q = new Queue();
            q.Enqueue("A");
            q.Enqueue("B");
            q.Enqueue("C");
            q.Enqueue("D");

            // remove elements
            while (q.Count > 0)
                Console.WriteLine(q.Dequeue());

            Console.ReadKey();
        }
    }
}
