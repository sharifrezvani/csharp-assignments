using System;
using System.Collections.Generic;

namespace SixthAssignment
{

    public class Employee
    {

        public Employee(string fullName, string hourlyRate, string workingHours)
        {
            FullName = fullName;
            HourlyRate = hourlyRate;
            WorkingHours = workingHours;
            Salary = Convert.ToInt32(WorkingHours) * Convert.ToInt32(HourlyRate) * 24 * 12;
        }

        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        private string _hourlyRate;
        public string HourlyRate
        {
            get { return _hourlyRate; }
            set { _hourlyRate = value; }
        }
        
        private string _workingHours;
        public string WorkingHours
        {
            get { return _workingHours; }
            set { _workingHours = value; }
        }
        
        private int _salary;
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        
    }
   

    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> employeeList = new List<Employee>(5);

            for (int i = 1; i <= employeeList.Capacity; i++)
            {   
                Console.WriteLine($"Please enter the info for employee no.{i}");
                Console.WriteLine("Full name:");
                string fullName = Console.ReadLine();
                Console.WriteLine("Hourly rate (USD):");
                string hourlyRate = Console.ReadLine();
                Console.WriteLine("Working hours (per day):");
                string workingHours = Console.ReadLine();
                Console.WriteLine();
                

                employeeList.Add(new Employee(fullName, hourlyRate, workingHours));
            }

            foreach (var item in employeeList)
            {
                Console.WriteLine($"Name: {item.FullName}\nHourly rate: ${item.HourlyRate}\nWorking hours per day: {item.WorkingHours}\nSalary: ${item.Salary}");
                Console.WriteLine("\n");
                
            }
        }

    }
}