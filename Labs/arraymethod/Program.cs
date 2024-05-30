internal class Program
{
    private static void Main(string[] args)
    {
        int[] input = { 2, 8, 11, -15, 50 };

        void task4(int[] input)
        {
            int min = input[0];
            int minIndex = input[1];

            for (int i = 1; i < input.Length; i++)

            {
                if (input[i] < min)
                {
                    min = input[i];
                    minIndex = i;

                }

            }

            Console.WriteLine("Minimum value" + min);
            Console.WriteLine("Minimum value" + minIndex);
        }

    }
}
