
using System.Threading.Channels;

bool IsPrime(int num)
{
    if (num <= 1)
        return false;
    if (num <= 3)
        return true;

    if (num % 2 == 0 || num % 3 == 0)
        return false;

    int i = 5;
    while (i * i <= num)
    {
        if (num % i == 0 || num % (i + 2) == 0)
            return false;
        i += 6;
    }

    return true;
}

bool[] CheckPrimeNumbers(int[] numbers)
{
    bool[] primeFlags = new bool[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        primeFlags[i] = IsPrime(numbers[i]);
    }
    return primeFlags;
}
int[] numbers = Console.WriteLine(value: "Eded daxil edin");

bool[] primeFlags = CheckPrimeNumbers(numbers);
