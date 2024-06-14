using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Try-Catch

            Console.WriteLine("Lütfen 1.Sayıyı Giriniz: ");
            int sayi1 = 0, sayi2 = 0;
            try
            {
              
                sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Lütfen 2.Sayıyı Giriniz: ");
                sayi2 = int.Parse(Console.ReadLine());  //Olası hata verebilecek kodlar TRY bölümüne yazılır.
                Console.WriteLine("Toplam: " + (sayi1 + sayi2));//Try-Catch yapılanması maliyetli bir yapılanmadır.Gereksiz kodlar yazılmaması lazım daha az maliyet olsun diye.
            }
            catch 
            {
                Console.WriteLine("Lütfen doğru bir karekter giriniz.");  //Try hata vereceği zaman çalışacak kodlarda buraya yazılır.
                
            }



            #endregion
            Console.ReadLine();




        }
    }
}
