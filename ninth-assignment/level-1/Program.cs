using System;

namespace NinthAssignmentLevelOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> oddNumbers = new List<int>();

            oddNumbers.AddRange(Enumerable.Range(1, 100).ToList().Where(number => number % 2 == 1));

            Console.WriteLine($"\nCounting from 0 to 100:\n");

            Enumerable.Range(1, 100).ToList().ForEach(number => Console.Write($"{number}__"));            
        
            Console.WriteLine($"\n\nThe odd numbers between 0 and 100 are:\n");
            
            oddNumbers.ForEach(oddNumber => Console.Write($"{oddNumber}__"));

        }
    }
}