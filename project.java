import java.util.Scanner;

public class UcakRezervasyonProgrami {
    public static String IsimSoyisim;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String kalkisZamani1 = "2023-10-05T10:30:00";
        String kalkisZamani2 = "2023-10-12T10:30:00";
        String kalkisZamani3 = "2023-10-17T10:30:00";
        String kalkisZamani4 = "2023-10-24T10:30:00";

        UcakBilgileri ucak = new UcakBilgileri();
        ucak.model = "Kargo Uçağı";
        ucak.seriNo = 20204382691347L;
        ucak.yolcuKapasitesi = 50;
        ucak.tasimaKapasitesi = 200000;
        ucak.bakimTarihi = "01, 10, 2023";
        ucak.ucakRengi = "koyu yeşil";

        KargoBilgileri kargo = new KargoBilgileri();
        System.out.println("Gönderenin İsimi ve Soyadı:");
        kargo.gonderenAdSoyad = scanner.nextLine();
        System.out.println("Kargonun Türünü Giriniz: (Kırılacak, Boya, Ürün vb.)");
        kargo.tur = scanner.nextLine();
        System.out.println("Kilogram Cinsinden Ağırlığını Giriniz:");
        kargo.agirlik_kg = Integer.parseInt(scanner.nextLine());
        System.out.println("Gönderenin Numarasını Giriniz (XXXX) :");
        kargo.gondericiNo = Long.parseLong(scanner.nextLine());
        System.out.println("Alıcının Numarasını Giriniz (XXXX) :");
        kargo.aliciNo = Long.parseLong(scanner.nextLine());
        System.out.println("İletişim Bilgilerinizi Giriniz (Telefon Numarası) +90");
        kargo.iletisimBilgileri = scanner.nextLine();

        LokasyonBilgileri lokasyon = new LokasyonBilgileri();
        System.out.println("Kargonun Gideceği Ülkeyi Giriniz:");
        lokasyon.ulke = scanner.nextLine();
        System.out.println("Kargonun Gideceği Şehri Giriniz:");
        lokasyon.sehir = scanner.nextLine();
        System.out.println("Kargonun Gönderileceği Havaalanını Giriniz:");
        lokasyon.havaalani = scanner.nextLine();
        System.out.println("Doluluk Nedeniyle En Yakın Tarih Olan " + kalkisZamani1 + " Tarihine " + lokasyon.ulke + "/" + lokasyon.sehir + "/" + lokasyon.havaalani + " Konumunda Kaydınız Oluşturulmuştur.");
    }
}

class UcakBilgileri {
    public String model;
    public long seriNo;
    public int yolcuKapasitesi;
    public int tasimaKapasitesi;
    public String bakimTarihi;
    public String ucakRengi;
}

class KargoBilgileri {
    public String gonderenAdSoyad;
    public String tur;
    public int agirlik_kg;
    public long gondericiNo;
    public long aliciNo;
    public String iletisimBilgileri;
}

class LokasyonBilgileri {
    public String ulke;
    public String sehir;
    public String havaalani;
}
