using System;

namespace SecondAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Determine the number of rows for the pyramid (1-9): ");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= rows; i++)
            {

                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int h = 1; h <= i; h++)
                {
                    Console.Write($"{h}");
                }

                for (int k = i - 1; k >= 1; k--)
                {
                    Console.Write($"{k}");
                }
                
                Console.WriteLine("");

            }
        }
    }
}