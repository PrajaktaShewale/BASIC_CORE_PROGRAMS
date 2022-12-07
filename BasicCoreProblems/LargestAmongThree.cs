using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class LargestAmongThree
    {
        public void Largest()
        {
            Console.WriteLine("Find the Largest number Among three");
            Console.WriteLine("Enter thress numbers");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            if (first >= second && first >= third)
            {
                Console.WriteLine(first +" is a Largest among three number");
            }
            else if (second>=third)
            {
                Console.WriteLine(second + " is Largest among three numbers");
            }
            else
            {
                Console.WriteLine(third + " is Largest among three numbers");
            }
        }
    }
}
