using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace instance1
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.ReadLine();
            Console.WriteLine($"Age: {Age}");
            Console.ReadLine(); 
            Console.WriteLine($"Salary: ${Salary:F2}");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee("John Doe", 30, 50000.00M);

           
            employee1.DisplayDetails();
        }
    }
    





}
