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
    }


}
