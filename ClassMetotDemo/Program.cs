using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1 = new Musteri();
            customer1.Name = "Ali";
            customer1.Surname = "Veli";
            customer1.Id = 2132;

            Musteri customer2 = new Musteri();
            customer2.Name = "Ahmet";
            customer2.Surname = "Mehmet";
            customer2.Id = 2132;

            Musteri customer3 = new Musteri();
            customer3.Name = "Ayşe";
            customer3.Surname = "Tuğba";
            customer3.Id = 2132;

            Musteri[] musteriler = new Musteri[] {customer1, customer2, customer3};

            MusteriManager islem = new MusteriManager();
            Console.WriteLine(" ******Müşteri ekleme bölümü******\n");
            islem.Ekle(customer2);
            Console.WriteLine("******Müşteri Silme bölümü******\n");
            islem.Sil(customer3);
            Musteri[] liste = new Musteri[] { customer1, customer2, customer3 };
            Console.WriteLine("******Listeleme Bölümü*****\n");
            islem.Listele(liste);


            Console.WriteLine("*****Müşteri bilgileri ekleme bölümü******\n");
              
            
            foreach (var x in musteriler)
            {
                
               Console.WriteLine(x.Name+" "+ x.Surname + "\n" +x.Id+ "\n");
                
            }
            Console.ReadLine();

        }
    }
}
