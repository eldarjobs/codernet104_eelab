using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee.Models
{
    public class SalariedEmployee : Employee
    {
        public static int _id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public SalariedEmployee()
        {
            _id++;
            Id = _id;
        }


        public double CalculateSalary()
        {
            return this.Salary;
            
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Id: {this.Id}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Surname: {this.Surname}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine($"Salary: {this.Salary}");
            
        }
    }
}
