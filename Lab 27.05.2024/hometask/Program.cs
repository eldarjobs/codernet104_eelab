using Task;


Console.Write("Add array size: ");
int count = Convert.ToInt32(Console.ReadLine());
int index = 0;
int j;
while (index < count)
{
    j = 0;
    List<int> list = Task1.AddList(count);
    int[] arr = list.ToArray();
    while (j < arr.Length)
    {
        Console.Write(arr[j] + " ");
        j++;

    }
    Console.WriteLine("\n");
    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXX");

    index++;

}