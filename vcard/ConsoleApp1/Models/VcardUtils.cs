using System;
using System.IO;

public static class VCardUtils
{
    public static string ToVCardFormat(VCard vcard)
    {
        return $"BEGIN:VCARD\n" +
               $"VERSION:3.0\n" +
               $"FN:{vcard.Firstname} {vcard.Surname}\n" +
               $"EMAIL:{vcard.Email}\n" +
               $"TEL:{vcard.Phone}\n" +
               $"ADR:;;{vcard.City};;{vcard.Country}\n" +
               $"END:VCARD";
    }

    public static void SaveVCardToFile(VCard vcard)
    {
        // Proje dizininde vCards klasörünü belirle
        string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string saveDirectory = Path.Combine(projectDirectory, "vCards");

        // Dizinin var olup olmadığını kontrol et ve yoksa oluştur
        if (!Directory.Exists(saveDirectory))
        {
            Directory.CreateDirectory(saveDirectory);
        }

        // Dosya adını kullanıcı adı, soyadı ve Id kullanarak belirle
        string fileName = Path.Combine(saveDirectory, $"{vcard.Firstname}_{vcard.Surname}.vcf");

        string vcardData = ToVCardFormat(vcard);
        File.WriteAllText(fileName, vcardData);
    }
}
