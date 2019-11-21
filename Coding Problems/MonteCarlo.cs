using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Problems
{
    //The area of a circle is define as piRsquared. Estimate pi to three decimal places using monte carlo method. 

    class MonteCarlo
    {
        static int numberOfCores = Environment.ProcessorCount;
        static int iterations = 10000000 * numberOfCores;
        public static void MonteCarloCalc()
        {
            Console.WriteLine("Monte Carlo numeric simulation of PI");
            Console.WriteLine("Iteration limit: " + iterations);
            Console.WriteLine("Number of processor cores on system: " + Environment.ProcessorCount);
            Console.WriteLine("\nMONTE CARLO SIMULATION");

            MonteCarloPiApproximationSerialSimulation();

            Console.WriteLine();
            Console.ReadKey();
        }
        private static void MonteCarloPiApproximationSerialSimulation()
        {
            double piApproximation = 0;
            int total = 0;
            int inCircle = 0;
            double x, y = 0;
            Random rnd = new Random();

            while (total < iterations)
            {
                x = rnd.NextDouble();
                y = rnd.NextDouble();

                if ((Math.Sqrt(x * x + y * y) <= 1.0))
                    inCircle++;

                total++;
                piApproximation = 4 * ((double)inCircle / (double)total);
            }


            Console.WriteLine();
            Console.WriteLine("Approximated Pi = {0}", piApproximation.ToString("F3"));

        }
    }
}

