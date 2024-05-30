using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Eded");
        int[] sayilar = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int enKicik = sayilar[0];
        int enBuyuk = sayilar[0];

        foreach (int sayi in sayilar)
        {
            if (sayi < enKicik)
            {
                enKicik = sayi;
            }
            else if (sayi > enBuyuk)
            {
                enBuyuk = sayi;
            }
        }

        Console.WriteLine("En kicik: " + enKicik);
        Console.WriteLine("En boyuk: " + enBuyuk);
    }
}
