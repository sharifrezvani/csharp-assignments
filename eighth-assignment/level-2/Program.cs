using System;

namespace EightAssignmentLevelTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a text:");
            string givenString = Console.ReadLine();
            
            
            if (RecursiveCharacterCheck(givenString) == givenString.Length / 2)
            {
                Console.WriteLine("The text is mirrored!");
            }
            else
            {
                Console.WriteLine("The text is not mirrored!");
                
            }

        }

        public static int RecursiveCharacterCheck(string inputString)
        {

            int identicalCharacters = 0;

            if (inputString.Length <= 1)
                return identicalCharacters;

            if (inputString[0] == inputString[inputString.Length - 1])
            {
                identicalCharacters++;
            }

            return identicalCharacters + RecursiveCharacterCheck(inputString.Substring(1, inputString.Length - 2));

        }
    }
}