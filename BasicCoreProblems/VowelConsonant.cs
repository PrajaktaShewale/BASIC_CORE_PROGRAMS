using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class VowelConsonant
    {
        public void Alphabet()
        {
            Console.WriteLine("Find given char is Vowel Or Consonant");
            Console.WriteLine("Enter char to find");
            char ch = Convert.ToChar(Console.ReadLine());
            
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine(ch + " is vowel");
                        break;
                    case 'i':
                        Console.WriteLine(ch + " is vowel");
                        break;
                    case 'o':
                        Console.WriteLine(ch + " is vowel");
                        break;
                    case 'u':
                        Console.WriteLine(ch + " is vowel");
                        break;
                    case 'e':
                        Console.WriteLine(ch +" is vowel");
                        break;
                    default:
                        Console.WriteLine(ch + " is Consonant");
                        break;
                }
        }
    } 
}