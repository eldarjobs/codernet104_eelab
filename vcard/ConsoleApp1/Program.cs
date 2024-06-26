using System;
using System.Threading.Tasks;

public class Program
{
    static async Task Main(string[] args)
    {
        while (true)
        {
            Console.Write("Kaç adet vCard oluşturmak istiyorsunuz? (Çıkmak için q tuşuna basın): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
                break;

            if (!int.TryParse(input, out int totalCount) || totalCount <= 0)
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen pozitif bir tam sayı girin.");
                continue;
            }

            // Belirtilen sayıda kullanıcı verilerini API'den al
            var (data, validCount) = await HttpRequest.GetRandomUserDataAsync(totalCount);
            if (data != null)
            {
                // Verileri VCard nesnesine dönüştür
                VCard[] vcards = HttpRequest.ParseUserData(data);

                // Her vCard'ı dosyaya kaydet
                int createdCount = 0;
                foreach (var vcard in vcards)
                {
                    if (!string.IsNullOrEmpty(vcard.Firstname) && !string.IsNullOrEmpty(vcard.Surname) &&
                        !string.IsNullOrEmpty(vcard.Email) && !string.IsNullOrEmpty(vcard.Phone) &&
                        !string.IsNullOrEmpty(vcard.Country) && !string.IsNullOrEmpty(vcard.City))
                    {
                        VCardUtils.SaveVCardToFile(vcard);
                        Console.WriteLine($"{vcard.Firstname} {vcard.Surname} için vCard oluşturuldu.");
                        createdCount++;
                    }

                    if (createdCount >= totalCount)
                        break;
                }

                Console.WriteLine($"Toplam {createdCount} geçerli vCard oluşturuldu.");
            }
            else
            {
                Console.WriteLine("Kullanıcı verileri alınamadı. Lütfen tekrar deneyin.");
            }
        }

        Console.WriteLine("Programdan çıkılıyor...");
    }
}
