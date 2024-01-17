// See https://aka.ms/new-console-template for more information



using System.Runtime.InteropServices.Marshalling;

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "Yazılım Geliştirici Yetiştirme Kampı";
kurs1.Eğitmen = "Engin Demiroğ";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Eğitmen = "Engin Demir";
kurs2.IzlenmeOrani = 88;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Pyhton";
kurs3.Eğitmen = "Berke Sinan Sevinçli";
kurs3.IzlenmeOrani = 78;


Kurs[] kurslar=new Kurs[] {kurs1,kurs2,kurs3 };
foreach (var i in kurslar)
{
    Console.WriteLine(i.Eğitmen+" : "+i.KursAdi);
    
   
}

int[] sayılar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
foreach (var k in sayılar)
{
   if (k < 6)
    {
        Console.WriteLine(k);
    }

}








Console.Read();
class Kurs
{
    public string KursAdi;
    public string Eğitmen;
    public int IzlenmeOrani;
}