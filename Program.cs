using System;

namespace OkulYonetimSistemi
{
    // Person Sınıfı
    public class Person
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DogumTarihi { get; set; }

        public string Role { get; set; }

    } 
    class Program
    {
        static void Main(string[]args)
        {
            //Öğrencileri oluşturma
            Person ogrenci1 = new Person();
            ogrenci1.Ad = "Ciro";
            ogrenci1.Soyad = "Immobile";
            ogrenci1.DogumTarihi = "01.01.2000";
            ogrenci1.Role = "Öğrenci";

            // Öğrenci2
            Person ogrenci2 = new Person();
            ogrenci2.Ad = "Ahmet Emre";
            ogrenci2.Soyad = "Arı";
            ogrenci2.DogumTarihi = "01.01.2000";
            ogrenci2.Role = "Öğrenci";

            // Öğrenci3
            Person ogrenci3 = new Person();
            ogrenci3.Ad = "Behlül";
            ogrenci3.Soyad = "Haznedar";
            ogrenci3.DogumTarihi = "01.01.2000";
            ogrenci3.Role = "Öğrenci";

            // Öğretmen1
            Person ogretmen1 = new Person();
            ogretmen1.Ad = "Adnan";
            ogretmen1.Soyad = "Ziyagil";
            ogretmen1.DogumTarihi = "01.01.1980";
            ogretmen1.Role = "Öğretmen";

            // Öğretmen2
            Person ogretmen2 = new Person();
            ogretmen2.Ad = "Firdevs";
            ogretmen2.Soyad = "Yoreoglu";
            ogretmen2.DogumTarihi = "01.01.1980";
            ogretmen2.Role = "Öğretmen";

            // Konsola yazdırma
            PrintPerson(ogrenci1);
            PrintPerson(ogrenci2);
            PrintPerson(ogrenci3);
            PrintPerson(ogretmen1);
            PrintPerson(ogretmen2);
        }

        static void PrintPerson(Person person)
        {
            Console.WriteLine("Ad: " + person.Ad);
            Console.WriteLine("Soyad: " + person.Soyad);
            Console.WriteLine("Doğum Tarihi: " + person.DogumTarihi);
            if (string.IsNullOrEmpty(person.Role))
            {
                Console.WriteLine("Rol: Belirtilmemiş");
            }
            else
            {
                Console.WriteLine("Rol: " + person.Role);
            }
        }
    }
}
