using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 15;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 20;


            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.StokAdedi);

            }


            Console.WriteLine("--------------Metotlar-----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);

            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("Armut", "ankara armutu", 15, 5);

























            //Console.WriteLine("Hello World!");
        }
    }
}
