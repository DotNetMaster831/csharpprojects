using System;

namespace SimpleCalculatorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Enter first number");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose Operation (+ , -, /, *, %)");

                char userChoice = Convert.ToChar(Console.ReadLine());

                int result = 0;

                if (userChoice == '+')
                {
                    result = Add(num1,num2);
                    Console.WriteLine($"Result : {result}");
                }
                else if (userChoice == '-')
                {
                    Console.WriteLine($"Result : {num1 - num2}");
                }
                else if (userChoice == '*')
                {
                    Console.WriteLine($"Result : {num1 * num2}");
                }
                else if (userChoice == '/')
                {
                    Console.WriteLine($"Result : {num1 / num2}");
                }
                else if (userChoice == '%')
                {
                    Console.WriteLine($"Result : {num1 % num2}");
                }
                else
                {
                    Console.WriteLine("Inavlid Operation");
                }


                Console.WriteLine();


                Console.WriteLine("Do u want to continue? (y/n)");
                string cond = Console.ReadLine();

                if (cond.ToLower() != "y")
                    break;


                
            }


            
            //Console.ReadKey();
        }

        public static int Add(int num1, int num2)
        {
            return num1+num2;
        }






    }
}