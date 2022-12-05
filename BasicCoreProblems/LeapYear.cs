using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class LeapYear
    {
        public void FindLeap()
        {
            Console.WriteLine("Enter Year");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (Year%4 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("It is not a Leap Year");
            }
        }
    }
}
