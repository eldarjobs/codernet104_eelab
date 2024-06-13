using ENUM.Models;
using System.Drawing;

employee employee = new employee
{
    FirstName = "Ahmed",
    LastName = "Eldareey",
    Email = "kKbRk@example.com",
    Phone = "0123456789",
    Department = Departments.HR,
    SacRengi = Color.White,
    Status = Status.Cancelled,
};
employee.GetType()
    .GetProperties()
    .ToList()
    .ForEach(p => Console.WriteLine($"{p.Name.PadRight(15)} : {p.GetValue(employee)}"));

bool isDefined =Enum.IsDefined(typeof(Sehirler), "Izmirrrr");
Console.WriteLine(isDefined);

Sehirler sehir = (Sehirler)Enum.Parse(typeof(Sehirler), "Izmir");
Console.WriteLine(sehir);

