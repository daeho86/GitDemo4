using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = GetFactorial(1);
            Console.WriteLine(a);

            int b = GetFactorial(2);
            Console.WriteLine(b);

            int c = GetFactorial(3);
            Console.WriteLine(c);
        }

        static int GetFactorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * GetFactorial(n-1);
        }
    }
}
