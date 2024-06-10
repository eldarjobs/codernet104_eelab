using constructor.Models;

class Program
{
    static async Task Main(string[] args)
    {    
        var employee = new Employee
        {
            Id = 1,
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com",
            Phone = "123456789"
        };

      
        await employee.InitializeCreatedIpAsync();

        
        employee.PrintDetails();
    }
}
