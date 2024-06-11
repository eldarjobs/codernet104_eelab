using genericExample.Models;
using System.Security.Cryptography;
using static GenericExamples.Helpers.Helper;
using GenericExamples.Helpers;


namespace GenericExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Category category = new Category();
        Helper.Load(category);
        
        Product product = new Product();
        Helper.Load(product);


        Student student = new Student();
        Helper.Load(student);

        
        Helper.WriteToConsole(category);
        Helper.WriteToConsole(product);
        Helper.WriteToConsole(student);

        Console.ReadKey();



    }
}