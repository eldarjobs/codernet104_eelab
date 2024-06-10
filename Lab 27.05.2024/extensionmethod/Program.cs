public static class MyCustomResize
    {
        public static T[] CustomResize<T>(ref T[] array, int newSize, params T[] elements)
        {
            int originalLength = array.Length;
            int newLength = originalLength + elements.Length;

            T[] newArray = new T[newSize];

            int index = 0;
            for (int i = 0; i < newSize; i++)
            {
                Console.WriteLine($"Index: {index}, i: {i}, Array Length: {array.Length}, Elements Length: {elements.Length}");
                if (index < array.Length)
                {
                    newArray[i] = array[index];
                    index++;
                }
                else if (index < elements.Length)
                {
                    newArray[i] = elements[index];
                    index++;
                }
            }
            return newArray;
        }
    }