using System;

namespace odev_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama
            //1
            string [] renkler = new string[5];
            //2
            string [] hayvanlar = {"Kedi","Fare","Köpek","Tavşan","Balık"};
            //3
            int [] dizi;
            dizi = new int[5];

            // Dizilere Değer Atama ve Erişim
            renkler[0] = "Mavi";
            Console.WriteLine(renkler[0]);
            Console.WriteLine(hayvanlar[1]);// hayvanlardan 2. olanı yazar
            dizi[3] = 10; // diziye eleman ekleme
            Console.WriteLine(dizi[3]);

            // Dizilerde döngü
            Console.WriteLine("Lütfen Eleman Sayıyı Giriniz ");
            int uzunluk = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[uzunluk];

            for (int i = 0; i < uzunluk; i++)
            {
                Console.WriteLine("Lütfen {0}. Sayıyı Giriniz ",i+1);
                sayidizisi[i]= int.Parse(Console.ReadLine());

            }
            int toplam = 0;
            foreach (var sayi in sayidizisi)
            {
                toplam+= sayi;

            }
            Console.WriteLine("Ortalama : "+ toplam/uzunluk);
        }
    }
}
