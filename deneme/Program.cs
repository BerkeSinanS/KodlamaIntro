// See https://aka.ms/new-console-template for more information
using deneme;

Musteri musteri1=new Musteri();
musteri1.Id = 1;
musteri1.Name = "Stephen";
musteri1.Surname = "Curry";
musteri1.Age = 35;
musteri1.Gender = 'E';

Musteri musteri2 = new Musteri();
musteri2.Id = 1;
musteri2.Name = "Christiano";
musteri2.Surname = "Ronaldo";
musteri2.Age = 38;
musteri2.Gender = 'E';
    
Musteri musteri3 = new Musteri();
musteri3.Id = 1;
musteri3.Name = "LeBron";
musteri3.Surname = "James";
musteri3.Age = 39;
musteri3.Gender = 'E';

Musteri musteri4 = new Musteri();
musteri4.Id = 1;
musteri4.Name = "Micheal";
musteri4.Surname = "Jordan";
musteri4.Age = 60;
musteri4.Gender = 'E';

Musteri musteri6 = new Musteri();
musteri6.Id = 1;
musteri6.Name = "Lionel";
musteri6.Surname = "Messi";
musteri6.Age = 36;
musteri6.Gender = 'E';

Musteri musteri5 = new Musteri();
musteri5.Id = 1;
musteri5.Name = "Ebrar";
musteri5.Surname = "Karakurt";
musteri5.Age = 23;
musteri5.Gender = 'K';

Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5, musteri6 };
foreach (var musteri in musteriler)
{
    Console.WriteLine("İsim: "+ musteri.Name);
    Console.WriteLine("Soyisim: " + musteri.Surname);
    Console.WriteLine("Yaş: "+ musteri.Age);
    Console.WriteLine("Cinsiyet: "+ musteri.Gender);
    Console.WriteLine("-------------------");
}

MusteriManager e = new MusteriManager();
e.Ekleme(musteri1);











Console.Read();