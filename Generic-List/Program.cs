using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T -> object türündedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(1);
            sayiListesi.Add(2);
            sayiListesi.Add(3);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(6);
            sayiListesi.Add(7);
            sayiListesi.Add(8);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("siyah");
            renkListesi.Add("beyaz");
            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.Foreach ile elemanlara erişim
            foreach (int sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (string renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("kırmızı");

            sayiListesi.RemoveAt(2);
            renkListesi.RemoveAt(0);

            sayiListesi.ForEach((sayi) => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            if (sayiListesi.Contains(5))
            {
                Console.WriteLine("5 liste içerisinde bulundu");
            }

            //eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("siyah"));

            //Diziyi Liste çevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //Liste nasıl temizlenir
            hayvanlarListesi.Clear();


            //List içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici = new Kullanicilar();
            kullanici.Isim = "Yunus";
            kullanici.Soyİsim = "Başer";
            kullanici.Yas = 22;
            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Emre";
            kullanici2.Soyİsim = "Sırakaya";
            kullanici2.Yas = 20;

            kullaniciListesi.Add(kullanici);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Furkan",
                Soyİsim = "Kara",
                Yas = 27
            });

            foreach (Kullanicilar kisi in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı adı: "+kisi.Isim);
                Console.WriteLine("Kullanıcı soyadı: "+kisi.Soyİsim);
                Console.WriteLine("Kullanıcı yaşı: "+kisi.Yas);
            }

        }

    }
    public class Kullanicilar
    {
        private string isim;
        private string soyİsim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyİsim { get => soyİsim; set => soyİsim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
