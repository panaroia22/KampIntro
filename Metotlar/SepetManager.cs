using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi.... : "+ urun.UrunAdi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("eklendi"+urunAdi);

        }
    }
}
