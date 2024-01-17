using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class MusteriManager
    {
        public void musterimanager(Musteri musteri) 
        {
            
            Console.WriteLine("İsim: "+ musteri.Name);
            Console.WriteLine("Soyisim: "+ musteri.Surname);
            Console.WriteLine("Yaş: "+ musteri.Age);
            Console.WriteLine("Cinsiyet: "+ musteri.Gender);

        }
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("İsim: " + musteri.Name);
            Console.WriteLine("Soyisim: " + musteri.Surname);
            Console.WriteLine("Yaş: " + musteri.Age);
            Console.WriteLine("Cinsiyet: " + musteri.Gender);
        }
    }
}
