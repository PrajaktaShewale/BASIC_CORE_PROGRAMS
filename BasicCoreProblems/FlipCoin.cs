using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class FlipCoin
    {
        double HeadCount = 0,TailCount=0,PercentageOfHead=0,PercentageOfTail=0;
        public void CheckHeadTail()
        {
            Console.WriteLine("Eanter no. of times you want to flip the coin");
            double NumofCount =Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<NumofCount;i++)
            {
                Random ranobj = new Random();
                double randomnumber = ranobj.NextDouble();
               // Console.WriteLine(randomnumber);
                if(randomnumber <0.5)
                {
                    Console.WriteLine("Tail");
                    TailCount++;
                }
                else
                {
                    Console.WriteLine("Head");
                    HeadCount++;
                }
                
            }
            Console.WriteLine("total Tail count " + TailCount);
            Console.WriteLine("total Head count " + HeadCount);

            Console.WriteLine("******Percentage of Head and Tail******");
            PercentageOfHead = HeadCount / NumofCount * 100;
            Console.WriteLine("Percentage of Head" + PercentageOfHead);
            PercentageOfTail = TailCount / NumofCount * 100;
            Console.WriteLine("Percentage of Tail" + PercentageOfTail);
        }
    }
}
