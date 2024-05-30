namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1den 10e kadar sayıları ekrana yazdır.");
            
            Thread.Sleep(5000);

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 1; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }
                Console.WriteLine();
            }

        }
    }
}
