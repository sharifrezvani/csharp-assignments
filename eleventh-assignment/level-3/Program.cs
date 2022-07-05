using System;
using Newtonsoft.Json;

namespace EleventhAssignmentLevelThree
{

    public class Employee
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public int Age { get; set; }
        public string ip_address { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeesList = JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText(@".\Employee.json"));

            var desiredEmployees = from employee in employeesList
                                   where employee.Age > 20 && employee.gender == "Male"
                                   select employee;

            Console.WriteLine("Employees who are over 20 and male:\n");
            
            desiredEmployees.ToList().ForEach(desiredEmployee => Console.WriteLine($"{desiredEmployee.first_name} {desiredEmployee.last_name}"));
        }
    }
}