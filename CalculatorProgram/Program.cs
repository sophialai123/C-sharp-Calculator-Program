using System;
using System.Diagnostics;
using System.Text;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;
            int result;
            string answer;

            Console.WriteLine("Welcome to Calculator Program!");
            Console.WriteLine("Please enter the first number: ");

            //convert readline number into int
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");

            num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please choose the operation: ");
            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication, d for divsion");

            answer = Console.ReadLine();

            if (answer == "a") { result = num1 + num2; }
            else if (answer == "s") { result = num1 - num2; }
            else if (answer == "m") { result = num1 * num2; }
            else { result = num1 / num2; }

            Console.WriteLine($"The result is {result}.");

        }

    }

}



