// Degiskenler
//Console.WriteLine("Hello, World!");
//string message = "Merhaba";
//double price = 10000;
//int num = 10;
//bool isAuthenticated = false;

//string ad = "Ömer";
//string soyad = "Ayılmazdır";
//int dogumYili = 2000;
//long tcNo = 10676609858;

// Diziler - Arrays
// Referans Tipler : Array, Class, Interface, Abstract
// Referans tiplerde referansı atanır
using Business.Concrete;
using Entities.Concrete;

string[] ogrenciler = { "Ömer", "Mehmet", "Ali" };
for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1; // sehirler2 ref alır sehirler1
sehirler1[0] = "Adana";
Console.WriteLine(sehirler1[0]); // Adana 

//foreach (string sehir in sehirler1)
//{
//    Console.WriteLine(sehir);
//}

// Generic Collection
List<string> yeniSehirler = new List<string> { "Kars","İstanbul","İzmir"};
yeniSehirler.Add("Ankara eklendi...");
foreach (var sehir in yeniSehirler)
{
    Console.WriteLine(sehir);
}

// Değer Tipler : Int, Double, Bool
// Değer tiplerde, değeri atanır
// String veri tipi referans tiptir fakat değer tip gibi çalışır
int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
// sayi2=10 olur..



static void SelamVer(string Ad="İsimsiz Kullanıcı")
{
    Console.WriteLine("Merhaba " + Ad);
}

SelamVer("Ömer");
SelamVer();

static int Topla(int sayi1=5,int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc);
    return sonuc;
}

Topla(2, 50);


Person person1 = new Person();
person1.FirstName = "Ömer";
person1.LastName = "Ayılmazdır";
person1.NationalIdentity = 123;
person1.DateOfBirthYear = 2000;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);