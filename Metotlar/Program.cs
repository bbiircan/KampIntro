// See https://aka.ms/new-console-template for more information
using Metotlar;

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 13;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.Adi = "Kayısı";
urun2.Fiyati = 38;
urun2.Aciklama = "Kayseri Kayısısı";

Urun[] urunler = new Urun[] { urun1, urun2 };

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("---------------------------------");

}
Console.WriteLine("----------------Metotlar----------------");
//instance - örnek
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Erik", "Yeşil erik", 38, 10);
sepetManager.Ekle2("Elma", "Yeşil elma", 38, 9);
sepetManager.Ekle2("Kiraz", "Beyaz kiraz", 38, 8);