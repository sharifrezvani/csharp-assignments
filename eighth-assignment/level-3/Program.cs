using System;

namespace EightAssignmentLevelThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number:");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine($"\n{givenNumber} would be {RecursiveBinaryConverter(givenNumber)} in binary.");

        }

        public static string RecursiveBinaryConverter(int inputNumber)
        {

            int number = inputNumber;
            string result = "";
            
            if (number == 0)
            {
                return result;
            }
            
            return RecursiveBinaryConverter(number / 2) + $"{number % 2}";

        }
    }
}