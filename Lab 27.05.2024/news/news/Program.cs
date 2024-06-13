
using news.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var emp1 = new Employee("Eldar", "Eldarey", "eldareyvazli@gmail.com", "1234567890");
        var emp2 = new Employee("Eldar", "Eldarey", "eldareyvazli@gmail.com", "1234567890");
        if (emp1 == emp2)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not Equal");
        }

        Console.WriteLine(emp1);

        Employee emp3 = emp1 with { FirstName = "Salam" };
        Console.WriteLine(emp3);


      Catagory c = new();
       

    }
}