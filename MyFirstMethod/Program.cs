using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Method that runs the program class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CountToN(2);
            CountToN(5);
            CountTo10();
            CountToN(3,5);
        }

        /// <summary>
        /// Counts and prints the numbers 1-10
        /// </summary>
        private static void CountTo10()
        {
            CountToN(10);


        }

        /// <summary>
        /// Counts and prints the numbers 1-n
        /// </summary>
        /// <param name="n">Max number the counter goes to</param>
        private static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }


        }

        /// <summary>
        /// Counts and prints the numbers n1 - n2
        /// </summary>
        /// <param name="n1">The Start number it counts from</param>
        /// <param name="n2">The inclusive Max number it counts to</param>
        private static void CountToN(int n1, int n2)
        {
            for (int i = n1; i < n2 + 1; i++)            
            {
                Console.WriteLine(i);
            }
        }
    }


}
