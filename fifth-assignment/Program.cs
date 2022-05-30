using System;
using System.Collections.Generic;

namespace FifthAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> reoccurrences = new List<string>();

            string givenNumberString;

            string givenDigitString;


            do
            {
                Console.WriteLine("Enter a number(must be more than two digits):");
                givenNumberString = Console.ReadLine();
            } while (givenNumberString.Length <= 1);


            do
            {
                Console.WriteLine("Enter a single digit:");
                givenDigitString = Console.ReadLine();
            } while (givenDigitString.Length != 1);

            
            for (int i = 0; i < givenNumberString.Length; i++)
            {
                if (givenNumberString.Substring(i,1) == givenDigitString)
                {
                    reoccurrences.Add(givenDigitString);
                }
            }


            Console.WriteLine($"\nThe given digit occurs {reoccurrences.Count} time/times in the given number.");
            

        }
    }
}