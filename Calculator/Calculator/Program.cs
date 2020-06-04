using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose between +-/*% ");
            string mathType = Console.ReadLine();

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            switch (mathType)
            {
                case "-":
                    Subtraction(num1, num2);
                    break;
                case "/":
                    Division(num1, num2);
                    break;
                case "*":
                    Multiplication(num1, num2);
                    break;
                case "%":
                    Modulus(num1, num2);
                    break;

                default:
                    Addition(num1, num2);
                    break;
            }
        }

        static void Addition(int nr1, int nr2)
        {
            Console.WriteLine(nr1 + nr2);
        }
        static void Subtraction(int nr1, int nr2)
        {
            Console.WriteLine(nr1 - nr2);
        }
        static void Division(int nr1, int nr2)
        {
            Console.WriteLine(nr1 / Convert.ToDecimal(nr2));
        }
        static void Multiplication(int nr1, int nr2)
        {
            Console.WriteLine(nr1 * nr2);
        }
        static void Modulus(int nr1, int nr2)
        {
            Console.WriteLine(nr1 % nr2);
        }
    }
}
