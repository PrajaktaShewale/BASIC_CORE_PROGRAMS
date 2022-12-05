using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class PowerOf2
    {
        public void Power()
        {
            Console.WriteLine("Find the Power Of 2");
            Console.WriteLine("Enter the Power Number");
            int power=int.Parse(Console.ReadLine());
            if (power >=31)
            {
                Console.WriteLine("Overflow Please Enter below 31");
            }
            else
            {
                int p=power;
                int result = 1;
                while(power > 0)
                {
                    result = result * 2;
                    power--;
                }
                Console.WriteLine("Result of 2 power "+ p + " is " + result);
                }
        }
    }
}
