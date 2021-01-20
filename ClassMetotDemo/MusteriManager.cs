using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteriler :" + musteri.Name + " " + musteri.Surname+" "+musteri.Id+"\n");
        }

        public void Listele(Musteri[] musteri)
        {
            Console.WriteLine("Müşteri Listesi\n");
            foreach(Musteri y in musteri)
            {
                Console.WriteLine("Müşteri:"+" "+y.Name+" "+y.Surname+" "+y.Id+ "\n");
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşteriler :" +" "+ musteri.Name + " " + musteri.Surname +" "+ musteri.Id+ "\n");
        }

    }
}
