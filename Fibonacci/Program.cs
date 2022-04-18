using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fibonacci Number Shower\nChoose a number to show the respective Fibonacci Number");
            int answer = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(answer));
            
        }

        
        private static int Fibonacci(int n)
        {
            int theFibonacciNumber = 0;
            if((n==1) || (n == 2))
            {
                theFibonacciNumber = 1;
                return theFibonacciNumber;
            }
            else 
            {
                theFibonacciNumber = Fibonacci(n-1) + Fibonacci(n-2);
                return theFibonacciNumber;
            }
            
        }
    }
}
