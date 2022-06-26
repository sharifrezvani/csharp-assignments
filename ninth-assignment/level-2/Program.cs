using System;

namespace NinthAssignmentLevelTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string? number;

            do
            {
                Console.WriteLine("Enter a number with at least two digits:");
                number = Console.ReadLine();
            } while (number.Length < 2);



            List<char> characters = new List<char>();
            characters = number.ToList();

            List<int> digits = new List<int>();
            characters.ForEach(character => digits.Add(Convert.ToInt32(character.ToString())));


            bool isAscendingByTwo = digits.Where(digit => digits.IndexOf(digit) <= digits.Count - 2).All(digit => digit == digits[digits.IndexOf(digit) + 1] - 2);
            bool isDescendingByTwo = digits.Where(digit => digits.IndexOf(digit) <= digits.Count - 2).All(digit => digit == digits[digits.IndexOf(digit) + 1] + 2);


            if (isAscendingByTwo)
            {
                Console.WriteLine($"Each digit in {number} is ascending by 2.");
            }
            else if (isDescendingByTwo)
            {
                Console.WriteLine($"Each digit in {number} is descending by 2.");
            }
            else
            {
                Console.WriteLine($"Each digit in {number} is NOT ascending or descending by 2.");
            }
        }
    }
}