using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n <= 12; n++)
                Console.WriteLine(Fib(n));
        }
        static int Fib(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fib(n - 1) + Fib(n - 2);

        }
    }
}
