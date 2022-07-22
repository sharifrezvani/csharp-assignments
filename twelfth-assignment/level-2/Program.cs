using System;
using System.Linq;
using System.Collections;

namespace TwelfthAssignmentLevelTwo
{
    public class Person
    {
        public string? Name { get; set; }
        public int ID { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // Read the ReadMe.txt file !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!-------------------------------------------
            
            List<int> numbersList1 = new List<int>(){1, 2, 3, 4};
            List<int> numbersList2 = new List<int>(){1, 2, 3, 4};
            Console.WriteLine("Same lists with same order:\n");

            Console.WriteLine("Method without order => " + CheckEqualListsWithoutOrder(numbersList1, numbersList2));
            Console.WriteLine("Method with order => " + CheckEqualListsWithOrder(numbersList1, numbersList2) + "\n");


            List<int> numbersList3 = new List<int>(){1, 2, 3, 4};
            List<int> numbersList4 = new List<int>(){2, 4, 3, 1};
            Console.WriteLine("Same lists with different order:\n");

            Console.WriteLine("Method without order => " + CheckEqualListsWithoutOrder(numbersList3, numbersList4));
            Console.WriteLine("Method with order => " + CheckEqualListsWithOrder(numbersList3, numbersList4));    
        }

        // First Method (Order doesn't matter) -----------------------------------------------------------------------------------

        static public bool CheckEqualListsWithoutOrder<T>(List<T> firstList, List<T> secondList)
        {

            if (Enumerable.SequenceEqual(firstList.OrderBy(e => e), secondList.OrderBy(e => e)))
            {
                return true;
            }
            
            return false;

        }
        // Second Method (Order matters) ----------------------------------------------------------------------------------------
        static public bool CheckEqualListsWithOrder<T>(List<T> firstList, List<T> secondList)
        {
            int identicalItems = 0;

            if (firstList.Count() != secondList.Count())
            {
                return false;
            }
            else
            {
                for (var i = 0; i < firstList.Count; i++)
                {
                    if (firstList[i].Equals(secondList[i]))
                    {
                        identicalItems++;
                    }
                    
                    if (identicalItems == firstList.Count)
                    {   
                        return true;
                    }
                }
            }
            return false;
        }
    }
}