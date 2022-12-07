using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class EvenOdd
    {
        public void EvenOddNum()
        {
            Console.WriteLine("Find the given number is Even or Odd");
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if(num %2 == 0)//if n is divided by 2 and the remainder is equals to 0 then the statement is true
            {
                Console.WriteLine(num + " is Even Number");
            }
            else //else it is false.
            {
                Console.WriteLine(num + " is Odd Number");
            }
        }
    }
}
