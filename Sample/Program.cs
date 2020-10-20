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
<<<<<<< HEAD

=======
            Console.WriteLine("Welcome to world");
>>>>>>> f1a391310fcada0f9bdbe9d58803d248a08f3bce
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
