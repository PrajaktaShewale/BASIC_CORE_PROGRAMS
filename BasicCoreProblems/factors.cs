using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class factors
    {
        public void PrimeFact()
        {
            Console.WriteLine("Computes the prime factorization of N using brute force");//3 × 7 = 21
            int result = 1;
            Console.WriteLine("enter a number to check");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                result = result * i;
            }
            Console.WriteLine("Factorial of " + num + " is = " + result);
        }
    }
}
