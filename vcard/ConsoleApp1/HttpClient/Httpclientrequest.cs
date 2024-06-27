using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


public static class HttpRequest
{
    public static async Task<(string data, int validCount)> GetRandomUserDataAsync(int count)
    {
        try
        {
            HttpResponseMessage response = await client.GetAsync($"https://randomuser.me/api/?results={count}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return (responseBody, count);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Request error: {e.Message}");
            return (null, 0);
        }
    }

    public static VCard[] ParseUserData(string jsonData)
    {
        var json = JObject.Parse(jsonData);
        var users = json["results"];

        VCard[] vcards = new VCard[users.Count()];
        for (int i = 0; i < users.Count(); i++)
        {
            var user = users[i];
            vcards[i] = new VCard
            {
                Id = (string)user["login"]["uuid"],
                Firstname = (string)user["name"]["first"],
                Surname = (string)user["name"]["last"],
                Email = (string)user["email"],
                Phone = (string)user["phone"],
                Country = (string)user["location"]["country"],
                City = (string)user["location"]["city"]
            };
        }

        return vcards;
    }
}
public static class HttpRequestManual
{
    public static async Task<string> GetRandomManualUserDataAsync(int count, string nationality)
    {
        try
        {
            HttpResponseMessage response = await client.GetAsync($"https://randomuser.me/api/?results={count}&nat={nationality}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Request error: {e.Message}");
            return null;
        }
    }
}
