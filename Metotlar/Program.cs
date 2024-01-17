// See https://aka.ms/new-console-template for more information
using Metotlar;


Product urun1 = new Product();
urun1.Adi = "Elma";
urun1.Fiyati = 28;
urun1.Aciklama = "Amasya elması.";

Product urun2 = new Product();
urun2.Adi = "Karpuz";
urun2.Fiyati = 150;
urun2.Aciklama = "Diyarbakır karpuzu";

Product[] urunler = new Product[] { urun1, urun2 };

foreach (Product p in urunler)
{
    Console.WriteLine(p.Adi);
    Console.WriteLine(p.Fiyati);
    Console.WriteLine(p.Aciklama);
    Console.WriteLine("-----------");
}
Console.WriteLine("-------Metotlar-------");
SepetManager sepetManager= new SepetManager();
sepetManager.Ekle(urun2);
sepetManager.Ekle(urun1);









Console.Read();