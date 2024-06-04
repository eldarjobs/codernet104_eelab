using System;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Enter numbers: ");
        //string number = Console.ReadLine();
        //string[] array = number.Split(',');

        //double result = MthSquare(array.Select(int.Parse).ToArray());
        //Console.WriteLine(result);

        string mail = GenarateMail("eldar", "eyvazli");
        Console.WriteLine(mail);    
    }

    //private static double MthSquare(int[] arr)
    //{
    //    int sum = Enumerable.Sum(arr);
    //    double result = Math.Sqrt(sum);
    //    return result; 
    //}




    //private static double MthSquare(int[] arr)
    //{
    //    int sum = Enumerable.Sum(arr);
    //    double result = Math.Sqrt(sum);
    //    return result;
    //}   


    /// <summary>
    /// Mail gonderen methot
    /// Verilen deyerlere gore mail adresin gonderer
    /// </summary>
    /// <param name="FirstName">Kullanici Adi</param>
    /// <param name="LastName">Kullanicinin Soyadi</param>
    /// <returns>isim.soyisim@gmail.com</returns>

    private static string GenarateMail(string FirstName, string LastName)
    {
        return  $"{FirstName}.{LastName}@gmail.com";


        
    }
}
