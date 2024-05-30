using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Eded");
        int[] sayilar = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int cut = sayilar[0];
        int tek = sayilar[0];


        foreach (int sayi in sayilar)
        {
            if (sayi % 2 == 0)
            {
                cut = sayi;
                Console.WriteLine("Eded cutdur");
            }
            else if (sayi % 2 == 1)
            {
                tek = sayi;
                Console.WriteLine("Eded tekdir");
            }
        }

    }
}
