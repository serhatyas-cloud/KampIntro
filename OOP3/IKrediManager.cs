using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{

    //operasyonel metodlarda genelde interface kullanılır.
    // tüm kredi tiplerinin uygulaması zorunlu operasyonları tutsun diye interface kullanıyoruz
    //interfaceler birbirlerinin alternatifi olan kod içerikleri farklı olan durumlar için kullanırız.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
