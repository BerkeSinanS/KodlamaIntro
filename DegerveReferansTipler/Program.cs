// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int sayi1  = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
//sayi = 30 çünkü int,double,decimal,bool gibi sayı değerleri değer tip'tir

int[] sayilar1 = new int[] {10,20,30 };
int[] sayilar2 = new int[] { 100, 200, 300 };
sayilar1 = sayilar2;
sayilar2[0] = 999;
//sayilar1= 999 çünkü array,class, interface gibi değerler referans tip'tir