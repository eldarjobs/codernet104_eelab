using Abstract.models;
using System.Collections;

namespace Abstract;

internal class Program
{
    static void Main(string[] args)
    {
        Bateri bateri = new Bateri();
        bateri.Marka = "Yamaha";
        bateri.Model = "YMT-01";
        bateri.Aciklama = "Yamaha Metal Aleti";
        bateri.UretimYeri = "USA ";
        bateri.Fiyat = 1500;
        bateri.Hammadde = Hammadde.Agac;
        bateri.DeriTipi = "Koyun Deri";


        Keman keman = new Keman();
        {
            keman.Marka = "Yamaha";
            keman.Model = "YMT-02";
            keman.Aciklama = "Yamaha Metal Aleti";
            keman.UretimYeri = "USA ";
            keman.Fiyat = 2000;
            keman.Hammadde = Hammadde.Agac;
            keman.Teltipi = "Koyun Telti";
            keman.Arse = "Koyun Arse";

        };

        Gitar gitar = new();
        {
            gitar.Marka = "Yamaha";
            gitar.Model = "YMT-03";
            gitar.Aciklama = "Yamaha Metal Aleti";
            gitar.UretimYeri = "USA ";
            gitar.Fiyat = 2500;
            gitar.Hammadde = Hammadde.Agac;
            gitar.AkustikMi = true;
        }


        Piano piano = new Piano();

        {


            piano.Marka = "Yamaha";
            piano.Model = "YMT-04";
            piano.Aciklama = "Yamaha Metal Aleti";
            piano.UretimYeri = "USA ";
            piano.Fiyat = 3000;
            piano.Hammadde = Hammadde.Agac;
            piano.Teltipi = "Koyun Bal";
            piano.TusTakimi = "Koyun Cesit";

        }

        ArrayList muzikaletleri = new ArrayList();
        muzikaletleri.Add(bateri);
        muzikaletleri.Add(keman);
        muzikaletleri.Add(gitar);
        muzikaletleri.Add(piano);

        Console.WriteLine(bateri.Sound);
        Console.WriteLine(keman.Sound);
        Console.WriteLine(gitar.Sound);
        Console.WriteLine(piano.Sound);
    }
}
