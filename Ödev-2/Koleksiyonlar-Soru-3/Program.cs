using System;

namespace Soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cümle Giriniz.");
            string cumle = Console.ReadLine();
            char[] sesli ={'a','e','ı','i','u','ü','o','ö'};         
            string[] sesliTopla = new string[cumle.Length];           
            for (int i = 0; i < cumle.Length; i++)
            {
                for (int j = 0; j < sesli.Length; j++)
                {
                    if (cumle[i] == sesli[j])
                    {
                        sesliTopla[i] = cumle[i].ToString();                        
                    }
                }
            }

            foreach (var item in sesliTopla)
            {
                if (item!=null)
                {
                    Console.WriteLine(item);
                }
            }       
            Console.ReadLine();
        }
    }
}

