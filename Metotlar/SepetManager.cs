﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
     public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi: "+ urun.Adi);
        }   
        public void Ekle2(string urunAdi,string urunAciklamasi, double fiyati) 
        {
            Console.WriteLine("");
        }
    }
}
