using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3_Gun
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi."+":"+musteri.Name+":"+musteri.IbanNum    );   
        
        }
        public void Del(Musteri musteri)
        {

            Console.WriteLine("Müşteri silindi." + ":" + musteri.Name + ":" + musteri.IbanNum);
        }
        public void Update(Musteri musteri)
        {

            Console.WriteLine("Müşteri Güncellendi." + ":" + musteri.Name + ":" + musteri.IbanNum);
        }
    }
}
