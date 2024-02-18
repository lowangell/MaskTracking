using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround;

class Program
{
    static void Main(string[] args)
    {
       

        Vatandas vatandas1 = new Vatandas();

        SelamVer(isim:"Sila");
        SelamVer(isim:"Recep");
        SelamVer(isim:"Necmiye");
        SelamVer();

        int sonuc = Topla(6);

        
        string[] ogrenciler = new string[5];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Talha";
        ogrenciler[2] = "Ferhat";
        ogrenciler[3] = "Recep";
        ogrenciler[4] = "Sila";


        ogrenciler = new string[6];
        ogrenciler[5] = "Meryem";

       

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = { "Diyarbakır", "Balıkesir", "Samsun" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";

        Person person1 = new Person();
        person1.firstName = "Sila";
        person1.lastName = "Karahan";
        person1.dateOfBirthDayYear = 2004;
        person1.nationalIdentity = 548712365498;

        Console.WriteLine(sehirler2[0]);

        foreach (string sehir in sehirler2)
        {
            Console.WriteLine(sehir);
        }

        List<string> yeniSehirler = new List<string> { "Aydın", "Antalya", "Diyarbakır" };
        yeniSehirler.Add("İzmir");
        foreach (string sehir2 in yeniSehirler)
        {
            Console.WriteLine(sehir2);
        }


        PttManager pttManager = new PttManager(new ForeignerManager());
        pttManager.GiveMask(person1);


        //Değer tip
        int sayi1 = 10;
        int sayi2 = 20;

        sayi2 = sayi1;
        sayi1 = 30;
        Console.WriteLine(sayi2);


        Console.ReadLine();
    }

    static void SelamVer(string isim = "isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1, int sayi2 = 14)  
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam: " + sonuc);
        return sonuc;
    }
    private static void Degiskenler()
    {
        string mesaj = "merhaba";
        double tutar = 10000; 
        int sayi = 100;
        bool girisYapmisMi = false;

        string name = "Sila";
        string surname  = "Karahan";
        int birthYear = 2004;
        long tcNumber = 548712365498;

        Console.WriteLine(tutar * 1.20);
    }
}

public class Vatandas
{
    public string name { get; set; }
    public string surname { get; set; }
    public int birthYear { get; set; }
    public long tcNumber { get; set; }
}

