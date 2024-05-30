using System;

class Ucbucaq
{
    static void Main()
    {
        Console.Write("Ucbucaqin yukseklik olcusunu girin:");
        int yukseklik = int.Parse(Console.ReadLine());

        for (int i = 1; i <= yukseklik; i++)
        {
           
            for (int j = 1; j <= yukseklik - i; j++)
            {
                Console.Write(" ");
            }
          
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
            
        }
    }
}
