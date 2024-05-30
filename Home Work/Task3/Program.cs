using System;

namespace DigitsNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());


            int sum = 0;
            int counter = 0;

            while (number > 0)
            {
                counter++;
                sum += number % 10;
                number = (number - number % 10) / 10;

            }
            Console.WriteLine($"The sum of digits number {sum} number digits {counter} is ");

        }
    }
}


