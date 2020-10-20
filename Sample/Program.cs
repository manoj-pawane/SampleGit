using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to .net ");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to India");



            Console.WriteLine("Welcome to world");

            Console.WriteLine("Welcome to Universe");

            int a = 5;
            int c = 10;
            int sumOfTwoNumber = sum(a, c);
            Console.WriteLine(sumOfTwoNumber);

            int b = 4;
            int d = 5;
             sumOfTwoNumber= sum(b, d);
            Console.WriteLine(sumOfTwoNumber);
        }

        static int sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;

        }
    }
}
