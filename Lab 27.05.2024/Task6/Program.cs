using System;

class Task6
{
    static void Main()
    {
        int size = Console.ReadLine().Split().Select(int.Parse).Min();  

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
