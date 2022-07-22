using System;

namespace TwelfthAssignmentLevelOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>(){"Parviz","Iria","Peter","Asghar","Pangoiler","Arin","Akbar"};
            
            namesList.RemoveAll(name => name.ToUpper().StartsWith("PA"));
            
            namesList.ForEach(name => Console.WriteLine(name));
            
            
        }
    }
}