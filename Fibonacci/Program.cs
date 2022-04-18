using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Show instructions to the user
            Console.WriteLine("Welcome to Fibonacci Number Shower\nChoose a number to show the respective Fibonacci Number");
            //Wait for input
            int answer = int.Parse(Console.ReadLine());
            //Show result
            Console.WriteLine(Fibonacci(answer));
            
        }

        /// <summary>
        /// Depending on the n parameter return respective Fibonacci number in that n position
        /// </summary>
        /// <param name="n">The Number gotten from the user</param>
        /// <returns></returns>
        private static int Fibonacci(int n)
        {
            int theFibonacciNumber = 0;
            //If the positions are 1 or 2  
            if((n==1) || (n == 2))
            {
                //assign the value of 1
                theFibonacciNumber = 1;
                //and return result
                return theFibonacciNumber;
            }
            // In case the n is greater than 2 
            else if((n>2))
            {
                //assign to the variable the value resulted from the sum of the calling of the same fuction subtractin -1 and -2
                theFibonacciNumber = Fibonacci(n-1) + Fibonacci(n-2);
                //and return result
                return theFibonacciNumber;
            }
            else
            {
                //write error message
                Console.WriteLine("Invalid Input");
                //and return 0
                return 0;
            }
            
        }
    }
}
