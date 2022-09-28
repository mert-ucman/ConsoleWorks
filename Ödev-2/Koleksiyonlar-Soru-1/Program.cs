using System;
using System.Collections;

namespace Soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();
            ArrayList asalOlan = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                tekrardene:
                Console.WriteLine((i + 1) + ". Sayıyı Giriniz");
                
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n >= 0)
                    {
                        sayilar.Add(n);
                    }
                    else
                    {
                        Console.WriteLine("Lütfen pozitif farklı bir tam sayı giriniz! Devam etmek için lütfen herhangi bir tuşa basınız.");
                        Console.ReadKey();
                        goto tekrardene;
                    }
                }
                catch
                {
                    Console.WriteLine("Lütfen pozitif farklı bir tam sayı giriniz! Devam etmek için lütfen herhangi bir tuşa basınız.");
                    Console.ReadKey();
                    goto tekrardene;
                }
                
               
            }
           
            foreach (int sayi in sayilar)
            {
                int kontrol = 0;
                for (int s = 2; s < sayi; s++)
                {
                    if (sayi % s == 0)
                    {
                        kontrol++;
                    }

                }
                if (kontrol != 0)
                {
                    asalOlmayan.Add(sayi);
                }
                else
                {
                    asalOlan.Add(sayi);
                }
            }
            Console.Clear();
            sayilar.Reverse();
            asalOlan.Reverse();
            asalOlmayan.Reverse();       
            Console.WriteLine("***** Sayılar *****");
            foreach (var sayi1 in sayilar)
            {
                Console.WriteLine(sayi1);
            }

            Console.WriteLine("***** Asal Olan *****");
            foreach (var sayi2 in asalOlan)
            {
                Console.WriteLine(sayi2);
            }

            Console.WriteLine("***** Asal Olmayan *****");
            foreach (var sayi3 in asalOlmayan)
            {
                Console.WriteLine(sayi3);
            }
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("Asal Olan Eleman Sayısı: "+"["+asalOlan.Count+"]");
            Console.WriteLine("Asal Olmayan Eleman Sayısı: " +"["+asalOlmayan.Count+"]");
            Console.WriteLine("***********************************************************************");
            double asalOlanToplam = 0;
            double asalOlmayanToplam = 0;

            foreach (int sayi4 in asalOlan)
            {
                asalOlanToplam += sayi4;
            }
            double asalOlanOrt = asalOlanToplam / asalOlan.Count;
            foreach (int sayi5 in asalOlmayan)
            {
                asalOlmayanToplam += sayi5;
            }
            double asalOlmayanOrt = asalOlmayanToplam / asalOlmayan.Count;

            Console.WriteLine("Asal Sayıların Sayı Ortalaması: "+"["+asalOlanOrt+"]");
            Console.WriteLine("Asal Olmayan Sayıların Sayı Ortalaması: " +"["+asalOlmayanOrt+"]");
            Console.WriteLine("***********************************************************************");
            Console.ReadLine();
        }
    }
}
