using Constructor_.Models;

namespace Constructor_;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Employee employee = new Employee();

        employee.FirstName = "Eldar";
        employee.LastName = "Eyvazli";
        employee.Email = "eldareyvazli@gmail.com";
        employee.Phone= "123-456-7890";



        Console.WriteLine(employee.FirstName);
        Console.WriteLine(employee.LastName);
        Console.WriteLine(employee.Email);
        Console.WriteLine(employee.Phone);
        Console.WriteLine(employee.CreatedIp);
        Console.WriteLine(employee.UpdatedIp);
        Console.WriteLine(employee.CreatedLocalIp);

    }
}
