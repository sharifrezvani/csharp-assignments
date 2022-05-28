using System;

namespace FourthAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Word:");
            string s1 = Console.ReadLine();
            Console.WriteLine("");
            
            Console.WriteLine("Long Text:");
            string s2 = Console.ReadLine();
            Console.WriteLine("");

            bool searchResult = false;

            int searchLength = s2.Length - s1.Length;


            for (int i = 0; i <= searchLength; i++)
            {

                    if (s2.Substring(i, s1.Length) == s1)
                    {
                        searchResult = true;
                    }

            }

            if (searchResult)
            {
                Console.WriteLine($"\nThe Text does contain the word \"{s1}\"");
            } else {
                Console.WriteLine("\nNo Such word was found");
            }

        }
    }
}