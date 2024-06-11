using Interface_.Models;
using System.Collections;
using System.Reflection;
using System.Reflection.Metadata;

Kaleci kaleci = new Kaleci();
{
    kaleci.Ad = "Sahruddin";
    kaleci.Soyad = "Memmedeliyev";
    kaleci.Takim = "Antalyaspor";
    kaleci.FormaNo = "1";
    kaleci.Mevki = "Kale";
    kaleci.Agresivlik = 0;
    kaleci.SutGucu = 10;
    kaleci.TopKontrolu = 0;
    kaleci.Kondisyon = 0;
    kaleci.Maas = 3000;
}


Defans defans = new();
{
    defans.Ad = "Yusuf";
    defans.Soyad = "Yalcin";
    defans.Takim = "Antalyaspor";
    defans.FormaNo = "2";
    defans.Mevki = "Defans";
    defans.Agresivlik = 0;
    defans.SutGucu = 0;
    defans.TopKontrolu = 0;
    defans.Kondisyon = 0;
    defans.Maas = 3500;

}

ArrayList fudbolcular = new ArrayList();
{
    fudbolcular.Add(kaleci);
    fudbolcular.Add(defans);
}

foreach (var futbolcu in fudbolcular)
{
    if (futbolcu is Kaleci kapici)
    {
        foreach (PropertyInfo property in kapici.GetType().GetProperties())
        {
            Console.WriteLine($"{property.Name.PadRight(20)}: {property.GetValue(kapici)}");

        }
        Console.WriteLine(new string('-', 40));
    }
    else if (futbolcu is Defans mudafieci)
    {
       
        foreach (PropertyInfo property in mudafieci.GetType().GetProperties())
        {

            Console.WriteLine($"{property.Name.PadRight(20)}: {property.GetValue(mudafieci)}");
        }
        Console.WriteLine(new string('-', 40));
    }
}



