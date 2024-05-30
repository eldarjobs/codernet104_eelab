using System;

class Kvadrat
{
    static void Main()
    {
        Console.WriteLine("Kvadratın olcusunu girin: ");
        int boyut = int.Parse(Console.ReadLine());

        for (int i = 0; i < boyut; i++)
        {
            for (int j = 0; j < boyut; j++)
            {
                Console.Write("X");
            }
            Console.WriteLine();
        }
    }
}
