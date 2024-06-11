using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee.Models
{
    public class HourlyEmployee : Employee
    {
        public static int _id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Hours { get; set; }
        public double Rate { get; set; }
        public HourlyEmployee()
        {
            Id = _id;
            _id++;
        }

        public double CalculateSalary()
        {
            return this.Rate * this.Hours;
            throw new NotImplementedException();
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Id: {this.Id}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Surname: {this.Surname}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine($"Hours: {this.Hours}");
            Console.WriteLine($"Rate: {this.Rate}");
        }
    }
}
