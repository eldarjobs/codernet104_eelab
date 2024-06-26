using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

// API istekleri için sınıf
public class HttpRequest
{
    // HttpClient nesnesi oluştur
    private static readonly HttpClient client = new HttpClient();

    // Belirtilen sayıda kullanıcı verisi çeken asenkron metod
    public static async Task<(string data, int validCount)> GetRandomUserDataAsync(int count)
    {
        try
        {
            // API'ye GET isteği gönder
            HttpResponseMessage response = await client.GetAsync($"https://randomuser.me/api/?results={count}");
            // İstek başarılı mı kontrol et
            response.EnsureSuccessStatusCode();
            // Yanıtı string olarak al
            string responseBody = await response.Content.ReadAsStringAsync();

            // Veriyi JSON olarak parse et
            var json = JObject.Parse(responseBody);
            var users = json["results"];

            // Filtreleme işleminden geçen veri sayısını bul
            int validCount = users.Count();
            for (int i = 0; i < users.Count(); i++)
            {
                var user = users[i];
                // Eğer istenmeyen karakter içeriyorsa, validCount'u azalt
                if (!IsValidUserData(user))
                {
                    validCount--;
                }
            }

            return (responseBody, validCount);
        }
        catch (HttpRequestException e)
        {
            // Hata durumunda mesaj göster
            Console.WriteLine($"Request error: {e.Message}");
            return (null, 0);
        }
    }

    // JSON verisini VCard nesnesine dönüştüren metod
    public static VCard[] ParseUserData(string jsonData)
    {
        // JSON verisini JObject'e dönüştür
        var json = JObject.Parse(jsonData);
        // Kullanıcı verilerini al
        var users = json["results"];

        VCard[] vcards = new VCard[users.Count()];
        for (int i = 0; i < users.Count(); i++)
        {
            var user = users[i];
            vcards[i] = new VCard
            {
                Id = (string)user["login"]["uuid"],
                Firstname = FilterInvalidCharacters((string)user["name"]["first"]),
                Surname = FilterInvalidCharacters((string)user["name"]["last"]),
                Email = (string)user["email"],
                Phone = (string)user["phone"],
                Country = (string)user["location"]["country"],
                City = FilterInvalidCharacters((string)user["location"]["city"])
            };
        }

        return vcards;
    }

    // Kullanıcı verilerinin geçerliliğini kontrol eden metod
    private static bool IsValidUserData(JToken user)
    {
        // Sadece Latin alfabesi ve boşluk karakterlerine izin ver
        string allowedPattern = @"^[a-zA-Z\s]+$";
        if (!(Regex.IsMatch((string)user["name"]["first"], allowedPattern) &&
              Regex.IsMatch((string)user["name"]["last"], allowedPattern) &&
              Regex.IsMatch((string)user["location"]["city"], allowedPattern)))
        {
            return false;
        }
        return true;
    }

    // İstenmeyen karakterleri filtreleyen metod
    private static string FilterInvalidCharacters(string input)
    {
        char[] allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ".ToCharArray();
        char[] inputChars = input.ToCharArray();
        char[] resultChars = Array.FindAll(inputChars, c => Array.Exists(allowedChars, ac => ac == c));
        return new string(resultChars);
    }
}
