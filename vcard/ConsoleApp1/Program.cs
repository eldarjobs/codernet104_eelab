using System;
using System.Threading.Tasks;
using static HttpRequest;

public class Program
{
    static async Task Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Create vCards automatically");
            Console.WriteLine("2. Create vCards manually");
            Console.WriteLine("3. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    await CreateVCardsAsync();
                    break;
                case "2":
                    await CreateManualVCardsAsync();
                    break;
                case "3":
                    exit = true;
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    static async Task CreateVCardsAsync()
    {
        while (true)
        {
            Console.Write("How many vCards would you like to create? (Press 'e' to exit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "e")
                break;

            if (!int.TryParse(input, out int totalCount) || totalCount <= 0)
            {
                Console.WriteLine("Invalid number. Please enter a positive integer.");
                continue;
            }

            var data = await HttpRequest.GetRandomUserDataAsync(totalCount);
            if (data != null)
            {
                // Convert data to VCard objects
                VCard[] vcards = HttpRequest.ParseUserData(data);

                // Save each vCard to a file
                int createdCount = 0;
                foreach (var vcard in vcards)
                {
                    if (!string.IsNullOrEmpty(vcard.Firstname) && !string.IsNullOrEmpty(vcard.Surname) &&
                        !string.IsNullOrEmpty(vcard.Email) && !string.IsNullOrEmpty(vcard.Phone) &&
                        !string.IsNullOrEmpty(vcard.Country) && !string.IsNullOrEmpty(vcard.City))
                    {
                        VCardUtils.SaveVCardToFile(vcard);
                        Console.WriteLine($"vCard created for {vcard.Firstname} {vcard.Surname}.");
                        createdCount++;
                    }

                    if (createdCount >= totalCount)
                        break;
                }

                Console.WriteLine($"A total of {createdCount} valid vCards were created.");
            }
            else
            {
                Console.WriteLine("Failed to retrieve user data. Please try again.");
            }
        }
    }
    static async Task CreateManualVCardsAsync()
    {
        while (true)
        {
            Console.Write("How many vCards would you like to create? (Press 'e' to exit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "e")
                break;

            if (!int.TryParse(input, out int totalCount) || totalCount <= 0)
            {
                Console.WriteLine("Invalid number. Please enter a positive integer.");
                continue;
            }

            Console.Write("Enter the nationality (e.g., 'us', 'gb', 'fr' , 'tr'): ");
            string nationality = Console.ReadLine();

            if (string.IsNullOrEmpty(nationality))
            {
                Console.WriteLine("Invalid nationality. Please enter a valid nationality code.");
                continue;
            }

            var data = await HttpRequestManual.GetRandomManualUserDataAsync(totalCount, nationality);
            if (data != null)
            {
                VCard[] vcards = HttpRequestManual.ParseUserData(data);

                int createdCount = 0;
                foreach (var vcard in vcards)
                {
                    if (!string.IsNullOrEmpty(vcard.Firstname) && !string.IsNullOrEmpty(vcard.Surname) &&
                        !string.IsNullOrEmpty(vcard.Email) && !string.IsNullOrEmpty(vcard.Phone) &&
                        !string.IsNullOrEmpty(vcard.Country) && !string.IsNullOrEmpty(vcard.City))
                    {
                        VCardUtils.SaveVCardToFile(vcard);
                        createdCount++;
                        Console.WriteLine($"vCard created for {vcard.Firstname} {vcard.Surname}.");

                        if (createdCount >= totalCount)
                            break;
                    }
                }

                Console.WriteLine($"A total of {createdCount} valid vCards were created.");
            }
            else
            {
                Console.WriteLine("Failed to retrieve user data. Please try again.");
            }
        }
    }
}