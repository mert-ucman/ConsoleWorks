using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
           
        {   
            basla:
            Console.WriteLine("Lütfen Yapılacak İşlemi Seçiniz\n-------------------------------------------------");
            Console.WriteLine("1 - Çift Sayıları Bulma\n2 - M Sayısı Tam Bölenlerini ve Eşitini Bulma\n3 - Girilen Kelimeleri N Tane Kadar Tersten Yazdırma\n4 - Cümledeki Toplam Harf Sayısı ve Toplam Kelime Sayısını Bulma\n5 - Çıkış\n-------------------------------------------------");
            /*Console.WriteLine("2 - M Sayısı Tam Bölenlerini ve Eşitini Bulma");
            Console.WriteLine("3 - Girilen Kelimeleri N Tane Kadar Yazdırma");
            Console.WriteLine("4 - Cümledeki Toplam Harf Sayısı ve Toplam Kelime Sayısını Bulma");*/
            int secim = Convert.ToInt32(Console.ReadLine());
            int metodsecim;
           
                if(secim==1)
                {

                        metod1:
                        Console.WriteLine("===========================================================");
                        Console.Write("Lütfen Sayı Adetini Giriniz: ");
                        int sayi1=Convert.ToInt32(Console.ReadLine());
                         Console.WriteLine("===========================================================");          
         
            
                        int[] dizi=new int[sayi1];
                        Console.WriteLine("Lütfen "+ sayi1 +" Adet Pozitif Sayı Giriniz: ");
                        for(int i=0;i<sayi1;i++)
                        {
                         Console.Write((i+1) +" . Sayıyı Giriniz: ");
                        dizi[i]=Convert.ToInt16(Console.ReadLine());
                        }
                         
            
                        Console.WriteLine("====================== ÇİFT SAYILAR ========================");

                        for(int j=0;j<dizi.Length;j++)
                        {
                            if(dizi[j]%2==0)
                            {                              
                                Console.Write(dizi[j]+" ");                   
                            }                     
                        }
                        Console.WriteLine("");
                        Console.WriteLine("===========================================================");
                        soru1:
                        Console.WriteLine("1 - Tekrar Deneyiniz, 2 - Ana Menüye Dönün ");
                        metodsecim=Convert.ToInt32(Console.ReadLine());
                        if(metodsecim==1)
                        {
                            Console.Clear();
                            goto metod1;
                        }
                        else if (metodsecim == 2)
                        {
                            Console.Clear();
                            goto basla;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Bir Seçim Yapınız.");
                            Console.Clear();
                            goto soru1;
                        }
                        
                }

                else if(secim==2)
                {
                        metod2:
                        int sayac=0;
                        Console.WriteLine("===========================================================");
                        Console.Write("Lütfen 1.Sayıyı(N) Giriniz: ");
                        int sayi2=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("===========================================================");
                        Console.Write("Lütfen 2.Sayıyı(M) Giriniz: ");
                        int sayi3=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("===========================================================");               
         

                        int[] dizi2=new int[sayi2+1];
                        Console.WriteLine("Lütfen "+ sayi2 +" Adet Pozitif Sayı Giriniz: ");
                        for(int i=1;i<dizi2.Length;i++)
                        {
                            Console.Write((i) +" . Sayıyı Giriniz: ");
                            dizi2[i]=Convert.ToInt16(Console.ReadLine());
                        }
                         
            
                        Console.WriteLine("====================== M SAYISINA EŞİT SAYILAR ========================");

                        for(int j=1;j<dizi2.Length;j++)
                        {
                            if(dizi2[j]==sayi3)
                            {    
                                sayac++;                                                                          
                            }                                         
                        }
                        Console.Write("M sayısına eşit "+sayac+" adet sayı vardır"); 
                        Console.WriteLine("");
                        Console.WriteLine("=======================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("====================== M SAYISININ TAM BÖLENLERİ ========================");

                        for(int j=1;j<dizi2.Length;j++) //Length değil 
                        {
                            if(sayi3%dizi2[j]==0)
                            {                              
                                Console.Write(dizi2[j]+" ");                   
                            }                    
                        }
                        Console.WriteLine("");
                        Console.WriteLine("=======================================================================");                      
                        soru2:
                        Console.WriteLine("1 - Tekrar Deneyiniz, 2 - Ana Menüye Dönün");
                        metodsecim=Convert.ToInt32(Console.ReadLine());
                        if(metodsecim==1)
                        {
                            Console.Clear();
                            goto metod2;
                        }
                        else if (metodsecim == 2)
                        {
                            Console.Clear();
                            goto basla;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Bir Seçim Yapınız.");
                            Console.Clear();
                            goto soru2;
                        }
                }

                else if(secim==3)
                {       
                        metod3:
                        Console.WriteLine("===========================================================");
                        Console.Write("Lütfen Sayı Adetini Giriniz: ");
                        int sayi1=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("===========================================================");          
         
            
                        string[] dizi=new string[sayi1];
                        Console.WriteLine("Lütfen "+ sayi1 +" Adet Kelime Giriniz: ");
                        for(int i=0;i<sayi1;i++)
                        {
                            Console.Write((i+1) +" . Kelimeyi Giriniz: ");
                            dizi[i]=Console.ReadLine();
                        }
                         
            
                        Console.WriteLine("======================= KELİMELER ========================");

                        for(int j=dizi.Length-1;j>=0;j--)
                        {
                            Console.Write(dizi[j]+" ");                    
                        }
                        Console.WriteLine("");
                        Console.WriteLine("===========================================================");
                        soru3:
                        Console.WriteLine("1 - Tekrar Deneyiniz, 2 - Ana Menüye Dönün");
                        metodsecim=Convert.ToInt32(Console.ReadLine());
                        if(metodsecim==1)
                        {
                            Console.Clear();
                            goto metod3;
                        }
                        else if (metodsecim == 2)
                        {
                            Console.Clear();
                            goto basla;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Bir Seçim Yapınız.");
                            Console.Clear();
                            goto soru3;
                        }
                }

                else if(secim==4)
                {       metod4:
                        Console.WriteLine("===========================================================");
                        Console.Write("Lütfen Cümle Giriniz: ");
                        string cumle=Console.ReadLine();                      
                        string[] cumledizi=cumle.Split(' ');                                            
                        Console.WriteLine("===========================================================");
                        Console.WriteLine("");
                        Console.WriteLine("======================= CÜMLEDEKİ KELİME SAYISI ========================");
                        Console.WriteLine("");
                        Console.WriteLine("Cümledeki toplam kelime sayısı : "+cumledizi.Length);
                        Console.WriteLine("");                      
                        Console.WriteLine("-------------------------------------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("======================= CÜMLEDEKİ HARF SAYISI ==========================");
                        Console.WriteLine("");
                        Console.WriteLine("Cümledeki toplam harf sayısı : "+cumle.Length);
                        Console.WriteLine("");
                        Console.WriteLine("========================================================================");
                        soru4:
                        Console.WriteLine("1 - Tekrar Deneyiniz, 2 - Ana Menüye Dönün");
                        metodsecim=Convert.ToInt32(Console.ReadLine());
                        if(metodsecim==1)
                        {
                            Console.Clear();
                            goto metod4;
                        }
                        else if (metodsecim == 2)
                        {
                            Console.Clear();
                            goto basla;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Bir Seçim Yapınız.");
                            Console.Clear();
                            goto soru4;
                        }
                }
                if(secim==5)
                {
                    Environment.Exit(1);
                }
                else
                {
                        Console.WriteLine("Lütfen Geçerli Bir Seçim Yapınız. Başa Dönmek İçin Bir Tuşa Basınız");
                        Console.ReadKey();
                        Console.Clear();                 
                        goto basla;
                }

                

                       

                

              


             

                  

            
            
            

            

            

          

        }
        
    }
}