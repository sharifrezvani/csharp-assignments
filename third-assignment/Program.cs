using System;

namespace ThirdAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = 0;
            int sum = 0;

            do
            {
                Console.WriteLine("Enter a natural number(1 and above):");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number <= 0);

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"The sum of all the odd numbers between and including 1 and {number} is {sum}.");
            
        }
    }
}