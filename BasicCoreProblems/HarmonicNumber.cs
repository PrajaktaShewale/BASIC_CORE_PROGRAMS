using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {
            Console.WriteLine("Find the Harmonic Numbers");
            Console.WriteLine("Enter Harmonic Value which we have to find");
            int HarmonicNum = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (int i = 0; i < HarmonicNum; i++)
            {
                result = result + ((double)1/i);

            }
            Console.WriteLine("nth Harmonic value = " + result);    
        }
    }
}
