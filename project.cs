using System;

namespace UcakRezervasyonProgrami
{
    internal class Program
    {
        public static string IsimSoyisim;

        static void Main(string[] args)
        {
            DateTime kalkisZamani1 = new DateTime(2023, 10, 05, 10, 30, 0);
            DateTime kalkisZamani2 = new DateTime(2023, 10, 12, 10, 30, 0);
            DateTime kalkisZamani3 = new DateTime(2023, 10, 17, 10, 30, 0);
            DateTime kalkisZamani4 = new DateTime(2023, 10, 24, 10, 30, 0);

            UcakBilgileri ucak = new UcakBilgileri();
            ucak.model = "Kargo Uçağı";
            ucak.seriNo = 20204382691347;
            ucak.yolcuKapasitesi = 50;
            ucak.tasimaKapasitesi = 200000;
            ucak.bakimTarihi = "01, 10, 2023";
            ucak.ucakRengi = "koyu yeşil";

            KargoBilgileri kargo = new KargoBilgileri();
            Console.WriteLine("Gönderenin İsimi ve Soyadı:");
            kargo.gonderenAdSoyad = Console.ReadLine();
            Console.WriteLine("Kargonun Türünü Giriniz: (Kırılacak, Boya, Ürün vb.)");
            kargo.tur = Console.ReadLine();
            Console.WriteLine("Kilogram Cinsinden Ağırlığını Giriniz:");
            kargo.agirlik_kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gönderenin Numarasını Giriniz (XXXX) :");
            kargo.gondericiNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Alıcının Numarasını Giriniz (XXXX) :");
            kargo.aliciNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("İletişim Bilgilerinizi Giriniz (Telefon Numarası) +90");
            kargo.iletisimBilgileri = Console.ReadLine();

            LokasyonBilgileri lokasyon = new LokasyonBilgileri();
            Console.WriteLine("Kargonun Gideceği Ülkeyi Giriniz:");
            lokasyon.ulke = Console.ReadLine();
            Console.WriteLine("Kargonun Gideceği Şehri Giriniz:");
            lokasyon.sehir = Console.ReadLine();
            Console.WriteLine("Kargonun Gönderileceği Havaalanını Giriniz:");
            lokasyon.havaalani = Console.ReadLine();
            Console.WriteLine("Doluluk Nedeniyle En Yakın Tarih Olan " + kalkisZamani1 + " Tarihine " + lokasyon.ulke + "/" + lokasyon.sehir + "/" + lokasyon.havaalani + " Konumunda Kaydınız Oluşturulmuştur.");
        }
    }

    internal class UcakBilgileri
    {
        public string model;
        public long seriNo;
        public int yolcuKapasitesi;
        public int tasimaKapasitesi;
        public string bakimTarihi;
        public string ucakRengi;
    }

    internal class KargoBilgileri
    {
        public string gonderenAdSoyad;
        public string tur;
        public int agirlik_kg;
        public long gondericiNo;
        public long aliciNo;
        public string iletisimBilgileri;
    }

    internal class LokasyonBilgileri
    {
        public string ulke;
        public string sehir;
        public string havaalani;
    }
}
