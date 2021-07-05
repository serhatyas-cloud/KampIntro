using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[]{ };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            //type safe - tip güvenli
            foreach (Urun item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("-------------");

            }

            Console.WriteLine("----------------------Metotlar----------------");

            //Instance - örnek
            //encasulation
            //class çağırırken bu hep yapılır.

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //bu yapmaman gereken bir yöntem (class yapısına uymuyor)
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 15, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 18, 8);
        }
    }
}


//Dont repeat yourself -DRY - Clean Code - Best Practice
