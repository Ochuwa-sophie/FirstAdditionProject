using System;

namespace firstproject
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;

            Console.Write("Please enter the first number: ");
            //This line is a comment. It doesn't affect our program.
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            //We are adding the values of firstNumber and 
            //secondNumber and saving the result in result variable
            result = firstNumber + secondNumber;
            Console.WriteLine("The answer is " + result);

        }
    }
}
