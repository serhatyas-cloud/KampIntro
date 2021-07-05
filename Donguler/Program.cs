using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazalım geliştirici yetişirme kursu";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Pyhton";
            string kurs5 = "C++";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array - dizi

            string[] kurslar = new string[] 
            { "Yazalım geliştirici yetişirme kursu",
                "Programlamaya başlangıç için temel kurs",
                "Java", "Pyhton", "C++" 
            };

            //for daha genel amaçlar için kullanılır

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            //foreach dizileri tek tek dolaşmaya yarıyor

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
