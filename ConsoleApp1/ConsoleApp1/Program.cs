using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            Console.WriteLine("Try and guess which of these are my favourite bird- Chicken, Parrot, Cockatoo...");
            string guess = Console.ReadLine().ToLower();
            switch(guess)
            { case "chicken":
                    Console.WriteLine("Yeah you guess right!");
                    break;
                case "parrot":
               case "cockatoo":
                    Console.WriteLine("Na you're wrong");
                    break;
                default:
                    Console.WriteLine("Absolutely not");
                    break;

               
            }


        }
    }
}
