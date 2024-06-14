using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Hata_Parametreleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Try-Catch Hata Parametreleri

            //Çalışma zamanında alınan hataya dair bizlere bilgi veren parametrelerdir.
            //int s1 = 0 , s2 = 10 ; //Burada dividebyzero hatası alacağız çünkü bir sayı 0 a bölünemez.
            //int a = s2 / s1;


            //object x = null;
            //x.ToString();  //Buradada NullReferenceException hatası alacağız.Çünkü null bir ifade stringe dönüştürelemez.

            //int.Parse("asdasa");//Buradada FormatException hatası alınacak çünkü metinsel bir ifade sayısala dönüştürelemez.

            //try
            //{
            //    int s1 = 0, s2 = 10; 
            //    int a = s2 / s1;
            //}
            //catch (Exception ex)//Bizlere fırlatılan hatayla ilgili tüm bilgileri getirecek olan bir üst türdür.(Yani bütün hataları karşılayabilen bir türdür.)Bu parantez kısmı yazılmak zorunda değildir ama yazılırsa hatanın türünü öğrenebiliriz.
            //{
            //    Console.WriteLine("Mesaj: " + ex.Message);

            //}


            #endregion
            #region Exception Dışında Farklı Bir Tür İle Hata Yakalama

            //try
            //{
            //    int s1 = 0, s2 = 10;
            //    int a = s2 / s1;
            //}
            //catch (DivideByZeroException ex)//Eğer ki parametre exception değil özelleştirilmiş bir hataya indirgenmişse böyle bir durumda sadece ilgili türe ait hataları yakalayabilecek karşılayabilecektir.
            ////Eğerki hata başka türe özgüyse try-catch bloğu yine patlayacaktır çünkü burda yazdığımız exception türe özgüdür.
            //{//Çözüm olarak bu durumda birden fazla catch bloğu ile diğer türdeki parametleri kontrol etmek olacaktır diğer derste öğreneceğiz.
            //    Console.WriteLine("Mesaj: " + ex.Message);

            //}




            #endregion
            #region Birden Çok Catch Durumu



            try
            {
                int s1 = 2, s2 = 10;
                int a = s2/s1;

                int.Parse("sadasda");
            }
            catch (DivideByZeroException ex)//DivideByZeroException hatası alındığında bu hatayı karşılayacak.
            {
                Console.WriteLine(ex.Message);
                
            }
            catch(FormatException ex) //FormatException hatasını karşılayacak catch bloğu.
            {

                Console.WriteLine(ex.Message);

            }   

            //Bu hatalar dışında farklı bir hata alınıyorsa o da farklı bir catch bloğunda kullanılmalıdır.Özelleştirilmiş türler ve exception varsa exception en sona yazılır çünkü exception atalarıdır.


            #endregion
            Console.ReadLine();


        }
    }
}
