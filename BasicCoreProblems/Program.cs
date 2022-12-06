using System;
namespace BasicCoreProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)//for reapeat input
            {
                Console.WriteLine("Welcome to Basic Core Programs");
                Console.WriteLine("1. Flip Coin" + "\n" + "2.Leap Year" + "\n" + "3.Power of 2" + "\n" + "4.Harmonic value"
                    + "\n" + "5.Factor" + "\n" + "6.Exit");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        FlipCoin flip = new FlipCoin();
                        flip.CheckHeadTail();
                        break;
                        case 2:
                            LeapYear leap = new LeapYear();
                        leap.FindLeap();
                        break;
                    case 3:
                        PowerOf2 pow = new PowerOf2();
                        pow.Power();
                        break;
                    case 4:
                        HarmonicNumber harmonic = new HarmonicNumber();
                        harmonic.Harmonic();
                        break;
                    case 5:
                        factors fact = new factors();
                        fact.PrimeFact();
                        break;
                        default:
                        flag = false;
                        break;
                }
            }
        }
    }
}