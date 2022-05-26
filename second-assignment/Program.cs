using System;

namespace SecondAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = 5;
            
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