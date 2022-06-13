using System;

namespace SeventhAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input;
            string reverseString; 

            do
            {
                Console.WriteLine("Enter a text:");
                input = Console.ReadLine();
                reverseString = RecursiveStringReverse(input);
            } while (input.Length == 0);


            Console.WriteLine($"That text in reverse would be:\n{reverseString}");


        }

        public static string RecursiveStringReverse(string inputString)
        {
            string baseString = inputString;
            int n = baseString.Length;
            string reverseString = "";

            if (reverseString.Length == baseString.Length)
            {
                return reverseString;
            }

            reverseString += baseString[n - 1].ToString();

            return reverseString + RecursiveStringReverse(baseString.Substring(0, n - 1)); ;
        }
    }
}