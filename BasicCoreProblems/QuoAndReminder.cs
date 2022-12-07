using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class QuoAndReminder
    {
        public void QuoRem()
        {
            Console.WriteLine("Compute the Quotient And Remainder problem");
            int quotient, reminder;
            Console.WriteLine("Enter Dividend - ");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Divisor - ");
            int divisor = int.Parse(Console.ReadLine());
            //quotient = dividend / divisor;
            //reminder = dividend % divisor;
            quotient = Math.DivRem(dividend, divisor, out reminder);
            Console.WriteLine("from the given input values we get Quotient is  "+ quotient + "  and Reminder is  "+ reminder);
        }
    }
}
