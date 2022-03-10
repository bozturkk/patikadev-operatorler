using System;

namespace Operatorler // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //operatörler
            //atama işlemli atama operatörleri
            //Mantıksal operatörler
            //İlişkisel operatörler
            //Aritmatik operatörler

            //atama
            int a = 1;

            //işlemli atama
            a = a + 1; //bu işlemin kısaltılmışı aşağıdaki gibidir. Aritmatik 4 işlem için de yapılabilir.
            a += 2;
            a -= 1;
            a /= 2;
            a *= 3; 
            //teker teker console da bir çağıralım bakalım noluyor :)
            Console.WriteLine(" ");
            Console.WriteLine("**********İşlemli atama**********");
            Console.WriteLine("a değerim                : {0}", a);
            Console.WriteLine(" -> a += 2 işlemi sonucu : {0} ", a += 2);
            Console.WriteLine(" -> a -= 1 işlemi sonucu : {0} ", a -= 1);
            Console.WriteLine(" -> a /= 2 işlemi sonucu : {0} ", a /= 2);
            Console.WriteLine(" -> a *= 3 işlemi sonucu : {0} ", a *= 3);
            
            // mantıksal operatörler
            // || , && , !

            bool basarili = true;
            bool tamamlandi = false;
            Console.WriteLine(" ");
            Console.WriteLine("**********Matıksal Operatorler**********");
            Console.WriteLine("basarili ve tamamlandi değerim : {0}, {1}", basarili,tamamlandi);
            if(basarili && tamamlandi) // ve
            {
                Console.WriteLine(" -> basarili && tamamlandı");
            }
            if(basarili || tamamlandi) // veya
            {
                Console.WriteLine(" -> basarili || tamamlandı");
            }
            if(basarili && !tamamlandi) // değil ise
            {
                Console.WriteLine(" -> basarili && !tamamlandi");
            }

            //ilişkisel operatörler
            // < , > , <= , >= , == , !=
            Console.WriteLine(" ");
            Console.WriteLine("**********İlişkisel Operatorler**********");
            int x = 3;
            int y = 4;
            bool sonuc; 
            sonuc = x<y;
            sonuc = x>y;
            sonuc = x<=y;
            sonuc = x>=y;
            sonuc = x==y;
            sonuc = x!=y;
            
            Console.WriteLine("x ve y değerim      : {0}, {1}", x,y);
            Console.WriteLine(" -> x<y'nin sonucu  : {0}", x<y);
            Console.WriteLine(" -> x>y'nin sonucu  : {0}", x>y);
            Console.WriteLine(" -> x<=y'nin sonucu : {0}", x<=y);
            Console.WriteLine(" -> x>=y'nin sonucu : {0}", x>=y);
            Console.WriteLine(" -> x==y'nin sonucu : {0}", x==y);
            Console.WriteLine(" -> x!=y'nin sonucu : {0}", x!=y);

            Console.WriteLine(" ");
            Console.WriteLine("**********Aritmatik Operatorler**********");
            // + , - , / , *
            int sayi1 = 10;
            int sayi2 = 13;
            int toplam = sayi1 + sayi2;
            toplam = sayi1 - sayi2;
            toplam = sayi1 / sayi2;
            toplam = sayi1 * sayi2;
            Console.WriteLine("sayi1 ve sayi2 değerim        : {0}, {1}", sayi1,sayi2);
            Console.WriteLine(" -> sayi1 + sayi2'nin sonucu  : {0}", sayi1 + sayi2);
            Console.WriteLine(" -> sayi1 - sayi2'nin sonucu  : {0}", sayi1 - sayi2);
            Console.WriteLine(" -> sayi1 / sayi2'nin sonucu  : {0}", sayi1 / sayi2);
            Console.WriteLine(" -> sayi1 * sayi2'nin sonucu  : {0}", sayi1 * sayi2);

            Console.WriteLine(" ");
            Console.WriteLine("**********Mod Alma İşlemi**********");
            // %
            int modIslemi = 20%3;
            Console.WriteLine("20'yi 3 e bölersem kalan : {0}", modIslemi);

        }
    }
}