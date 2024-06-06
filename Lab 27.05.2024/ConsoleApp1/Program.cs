using System;

public class UserData
{

    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; se
            
            
            t; }


    public void GetUserData()
    {
        Console.WriteLine("Please enter your name:");
        Name = Console.ReadLine();

        Console.WriteLine("Please enter your age:");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid input. Please enter a valid age:");
        }
        Age = age;

        Console.WriteLine("Please enter your email:");
        Email = Console.ReadLine();
    }


    public void DisplayUserData()
    {
        Console.WriteLine("\nUser Information:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Email: {Email}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        UserData user = new UserData();
        user.GetUserData();
        user.DisplayUserData();
    }
}
