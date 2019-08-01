using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Select an operator -,+,*,/");
            string input = Console.ReadLine();
            double result = 0;

            switch (input)
            {
                case "-":
                    result = num1 - num2;
                    break;
                case "+":
                    result = num1 + num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            Console.WriteLine("\n{0} {1} {2} = {3}", num1, input, num2, result);






        }
        }
    }

