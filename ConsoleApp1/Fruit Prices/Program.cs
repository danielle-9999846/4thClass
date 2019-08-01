using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Prices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Price Check on fruit- Apples, Bananas, Kiwifruit, Oranges");
           
            string fruit = Console.ReadLine().ToLower();
            string response;
            switch (fruit)
            { case "apples":
                    response = "Apples are $1.25/kg";
                    break;
                case "Bananas":
                   response = "Bananas are $3.15/kg";
                    break;
                case "Kiwifruit":
                    response = "kiwifruits are $4.65/kg";
                    break;
                case "oranges":
                    response = "oranges are $2.75/kg";
                    break;
                default:
                    response = "no, something went wrong";
                    break;
            }
            Console.WriteLine(response);
        }
    }
}
