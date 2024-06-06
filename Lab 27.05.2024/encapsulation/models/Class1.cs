using System;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        // Create a new NameValueCollection instance
        NameValueCollection myCollection = new NameValueCollection();

        // Add some key-value pairs
        myCollection.Add("key1", "value1");
        myCollection.Add("key2", "value2");
        myCollection.Add("key3", "value3");

        // Access values by key
        Console.WriteLine("Value for key1: " + myCollection["key1"]);

        // Iterate through all keys and values
        Console.WriteLine("All key-value pairs:");
        foreach (string key in myCollection.AllKeys)
        {
            Console.WriteLine($"Key: {key}, Value: {myCollection[key]}");
        }
    }
}
