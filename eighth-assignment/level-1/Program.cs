using System;

namespace EightAssignmentLevelOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base number:");
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power number:");
            int powerNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n{baseNumber} raised to the power of {powerNumber} would be {RecursivePower(baseNumber, powerNumber)}.");
        }



        public static int RecursivePower(int baseNumber, int powerNumber)
        {

            int n = baseNumber;
            int x = powerNumber;
            int result = 1;

            if (x == 0)
            {
                return result;
            }

            result *= n;
            return result * RecursivePower(baseNumber, powerNumber - 1);
        }
    }
}