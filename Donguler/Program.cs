// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//string urun1 = "Nike Defy All Day";
//string urun2 = "Nike Air Monarch";
//string urun3 = "Nike Air force";
//string urun4 = "Nike Air Jordan";
//string urun5 = "Nike Revulution NNN6";

//Console.WriteLine(urun1);
//Console.WriteLine(urun2);
//Console.WriteLine(urun3);
//Console.WriteLine(urun4);   
//Console.WriteLine(urun5);



string[]urunler=new string[] { "Nike Defy All Day" , "Nike Air Monarch" , "Nike Air force" ,
    "Nike Air Jordan","Nike Revulution NNN6" };

for (int i=0; i<urunler.Length; i++)
{
    Console.WriteLine(urunler[i]);
}
Console.WriteLine("For bitti");
foreach (string urun in urunler)
{
    Console.WriteLine(urun);
}

int sayi = -7;
string sonuc = (sayi > 0) ? "Pozitif" : "Negatif";
    Console.WriteLine(sonuc);













Console.Read();
