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
            string value;

            // (do while) loop used here


            do
            {
                int res;
                Console.WriteLine("Enter First Number");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Symbol(/,*,+,-):");
                string symbol = Console.ReadLine(); 
                
                
                //(switch case) used here instead of (if statement)
                
               switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Adition:" + res);
                        break;

                    case "-":
                        res = num1 + num2;
                        Console.WriteLine("Adition:" + res);
                        break;

                    case "*":
                        res = num1 + num2;
                        Console.WriteLine("Adition:" + res);
                        break;

                    case "/":
                        res = num1 + num2;
                        Console.WriteLine("Adition:" + res);
                        break;

                    default:

                        Console.WriteLine("Wrong Input");
                        break;
                }
                
                Console.ReadLine();
                Console.Write("Do You Want to Continue(Press y for Yes Press n for No)");
                value = Console.ReadLine();
            }
            while( value == "y" || value == "Y");




        }
    }
}
