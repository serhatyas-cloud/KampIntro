using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        //Method injection

        //BURDA TEK KREDİ GÖNDERİYOR
        public void BasvuruYap(IKrediManager krediManager,
            List<ILoggerService> loggerService)
        {
            //Başvuran blgilerini değerlendirme
            //
            krediManager.Hesapla();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }

        //KAÇ TANE KREDİ GÖNDERECEĞİ BELLİ OLMADIĞI İÇİN LIST KULLANIYORUZ
        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
