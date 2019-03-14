using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilk_proje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World"); //Ekrana çıktı verir ve işlem bittiğinde alt satıra geçer
            Console.Write("Hello World");

            byte myNumber = 0; // 0 ile 256 arası değişken alır.
            //int = 4 byte = 32 bit
            //byte = 1 byte = 8 bit

            int number = 100;
            var number2 = 200;
            //var değişkeni derleyicini otomatik olarak tip algılamasını yapmasını istediğim durumlarda kullanılıyor.
            Console.WriteLine(number);

            /*
             *** Değişken(Variable) Tanımlamak için yöntemler ***
             * <Veri Türü> <Değişken ismi>=<Değer>;
             * <Veri Türü> <Değişken ismi>;
             * <Veri Türü> <Değişken ismi>,<Değişken ismi>,...;
             * */
            //Primitive(ilkel) veri türü demek derleyici seviyesinde anlamlı veri türleri demek ve oluşturulması için başka veri tiplerine ihtiyaç yoktur.
            //Bir veri türü oluştururken ilkel v eri türlerine ihtiyaç duyuluyorsa bu companent veri türüdür
            /*
             * * Tamsayı Türleri**
             * sbyte -128-127 arasınd averi değeri alan işaretli veri türüdür
             * byte 0-255 
             * char 
             * "\0" herhangi bir değeri olmayan char demek
             */
            // sizeof()= bir verinin bellekte ne kadar yer kaplayacğını göstermektedir.
            /*
             * * Floating-Point(Kayan  Noktalı Türler) * *
             * float, double
             */

            // default(int) = int değerini default değerini döndürmektedir
            Console.WriteLine(default(int));

            int sayi1 = 0;
            int sayi2 = 0;
            int sonuc = 0;

            Console.Write("Bir sayi giriniz");
            //Giriş almak için
            sayi1 =Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayiyi giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplama : 1 , Çıkarma : 2 , Çarpma : 3 , Bölme : 4 ");
            int islemNo = Convert.ToInt32(Console.ReadLine());

            if (islemNo == 1)
                sonuc = sayi1 + sayi2;
            else if(islemNo == 2)
                sonuc = sayi1 - sayi2;
            else if (islemNo == 3)
                sonuc = sayi1 * sayi2;
            else if (islemNo == 4)
                sonuc = sayi1 / sayi2;
            else
                Console.WriteLine("Hatalı veri girdiniz");

            Console.Write("---------------------------");
            Console.Write(sonuc);

            Console.ReadKey();

       }
   }
}
