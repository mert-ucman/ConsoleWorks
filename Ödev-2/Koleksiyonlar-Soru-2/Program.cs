using System;
using System.Collections;


namespace Soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();
            ArrayList enKucuk = new ArrayList();
            ArrayList enBuyuk = new ArrayList();
            

            for (int i = 0; i < 20 ; i++)
            {
                Console.WriteLine((i+1)+".Sayıyı Giriniz");
                int n = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(n);
            }
            sayilar.Sort();
            double enKucukTop = 0;
            double enBuyukTop = 0;

            Console.WriteLine("***** En Küçük 3 Sayı *****");
            for (int j = 0; j < 3; j++)
            {
                enKucuk.Add(sayilar[j]);
                Console.WriteLine(sayilar[j]);
            }
            Console.WriteLine("***** En Büyük 3 Sayı *****");
            for (int x = 19; x > 16  ; x--)
            {
                enBuyuk.Add(sayilar[x]);
                Console.WriteLine(sayilar[x]);
            }
            Console.WriteLine("***************************");
            foreach (int sayi1 in enKucuk)
            {
                enKucukTop += sayi1;
            }

            foreach (int sayi2 in enBuyuk)
            {
                enBuyukTop += sayi2;
            }

            double enKucukOrt = enKucukTop / enKucuk.Count;
            double enBuyukOrt = enBuyukTop /enBuyuk.Count;
            Console.WriteLine("En Küçük Sayılar Ortalaması: "+ enKucukOrt);
            Console.WriteLine("En Büyük Sayılar Ortalaması: " + enBuyukOrt);

            double sayiOrtTop = enKucukOrt + enBuyukOrt;
            Console.WriteLine("Ortalamaların Toplamları: " + sayiOrtTop);
            Console.ReadLine();





        }
    }
}
