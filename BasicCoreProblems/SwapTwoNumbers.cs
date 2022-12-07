using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class SwapTwoNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Swap Two Numbers");
            Console.WriteLine("Enter Two numbers for swaping");
            int first =int.Parse(Console.ReadLine());
            int second =int.Parse(Console.ReadLine());
            Console.WriteLine("Before swap numbers " + first + " , " + second);
            int temp = first;
            first = second;
            second = temp;
            Console.WriteLine("After Swap numbers " + first + " , " + second);

        }
    }
}
