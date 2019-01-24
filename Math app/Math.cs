using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_app
{
    public class Math
    {
        public void Equation()
        {
            try
            {
              
                //asking user what math equation they are trying to do
                Console.WriteLine("Select one:\n\t1 for addition\n\t2 for subtraction\n\t3 for multiplication\n\t4 for division\n\t5 to quit");
                double e = Convert.ToDouble(Console.ReadLine());

                switch(e)
                {
                    case 1:
                        Calculate("+");
                        break;
                    case 2:
                        Calculate("-");
                        break;
                    case 3:
                        Calculate("*");
                        break;
                    case 4:
                        Calculate("/");
                        break;
                    default:
                        Environment.Exit(0);
                        break;

                }

            }
            catch (Exception)
            {
                Equation();

            }
            Console.ReadKey();
            Equation();
        }
        public void Calculate(string mathType)
        {
            try
            { 
            Console.WriteLine("Enter first number:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = 0;
            switch (mathType)
            {
                case "+":
                    c = a + b;
                    Console.WriteLine($"{a} + {b} = {c}");
                    break;
                case "-":
                    c = a - b;
                    Console.WriteLine($"{a} - {b} = {c}");
                    break;
                case "*":
                    c = a * b;
                    Console.WriteLine($"{a} * {b} = {c}");
                    break;
                case "/":
                    while(b<=0)
                    {
                        Console.WriteLine("Invalid number. Input a new second number that is geater than 0:");
                        b = Convert.ToDouble(Console.ReadLine());
                    }
                    c = a / b;
                    Console.WriteLine($"{a} / {b} = {c}");
                    break;
            }
            }
            catch(Exception)
            {
                Console.WriteLine("Not a valid number.");
                Calculate(mathType);

            }

        }
    }
}