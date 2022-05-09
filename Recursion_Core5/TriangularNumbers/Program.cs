using System;

namespace TriangularNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 10; n++)
                Console.WriteLine("N:  " + n + "T(n): " +Tri(n));
        }
        static int Tri(int n)
        {
            if (n == 1)
                return 1;
            else
                return n + Tri(n - 1);

        }


    }
}
