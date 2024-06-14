using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Switch Case
            //Switch case,kodun akışında belirli bir şarta göre yönlendirme yapmamızı sağlayan yapılanmadır.
            //Switch Case yapılanması bir değişkenin değerini sadece eşitlik durumlarını kontrol ederken kullanılır.
            //Sadece eşitlik durumu check edilecekse o zaman switch kullanılabilir.
            //Kontrol edilen değerin türü ne ise case bloklarında da aynı turde değerlerle kontrol edilmelidir
            //Switch parantezinde kontrol edilen değer bir değişken yahut sabit/static bir değer olabilirken case bloklarındaki değerler kesinlikle sabit/static olmalıdır.Caselerdeki değerler değişkenlerden alınamaz.
            //Default case bloklarından hiçbirine girmiyorsa default tetiklenir.
            //Eşitlik sağlandığı durumda diğer case bloklarına bakmadan switch caseden çıkacaktır.
            //Case bloklarının sıralaması ve defaultun yerleştirildiği yer önemli değildir.
            string adi = "Ahmet";
            switch (adi)
            {
                case "Mehmet":
                    Console.WriteLine("Adı Mehmet");
                    break;
                case "Ahmet":
                    Console.WriteLine("Adı Ahmet");
                    break;
                case "Hilmi":
                    Console.WriteLine("Adı Hilmi");
                    break; 

                default:
                    Console.WriteLine("Hiçbiri Değil");
                    break;
            }



            #endregion
            #region Switch Case When
            //Switch yapılanmasında sadece elimizdeki değerin eşitlik durumunu kontrol edebilmekteyiz.Bunun dışında bu kontrol esnasında farklı şartlarda değerlendirmek istiyorsak eğer when keywordunu kullanabiliriz.
            int satisTutar = 1000;
            switch (satisTutar)
            {
                case 1000 when (3 == 5):

                    break;
                case 1000 when (3 == 3):

                    break;

                default:

                    break;
            }
            #endregion
            #region Switch Case goto
            //Switch case yapılanmasında sadece eşitlik durumunu inceleyebildiğimiz için mantıksal bir işlem gerçekleştiremiyoruz.Dolayısıyla bazen farklı değerlere eşit olma durumunda aynı operasyonu/kodu/akışı kullanacağımız senaryolarla karşılaşmaktayız.
            //Farklı eşitliklerde aynı kodu çalıştıracaksak eğer kod tekrarına girmemek için goto keywordu ile su casedeki kodu çalıştır diyebiliyoruz...Yani caseler arasında zıplama yapabiliyoruz.

            int i = 10;
            switch (i)
            {
                case 5:
                    Console.WriteLine(i * 10);
                    break; 
                case 6:
                    Console.WriteLine(i / 5);
                    break;
                case 7:
                    goto case 5;//Case 5 deki kodu çalıştır demiş oluyoruz.goto kullanılan casede break komutunu kullanmıyoruz.
                case 10:
                    goto case 5;
                //Birden fazla aynı case'e yonlendırilen goto keywordunun kullanıldığı durumlarda su sekılde daha pratik bir yaklaşım yapabilmekteyiz.
                /*
                 * case 7:
                  case 10:
                       goto case 5;
                 */


                default:

                    break;
            }


            #endregion
            #region Switch Expressions
            #region Eski Yöntem
            string isim = "";
            int a = 10;
            switch (a)
            {
                case 5:
                    isim = "Hilmi";
                    break;
                case 7:
                    isim = "Rıfkı";
                    break;
                case 10:
                    isim = "Gençay";
                    break;

                default:

                    break;
            }
            #endregion
            #region Yeni Yöntem
            //Bunlar tek satırlık kodları atarken yapılabilir.
            /*
            int c = 10;
            string isim1 = c switch
            {
                5 => "Hilmi",
                7 => "Rıfkı",
                10 => "Gençay"
            };
            */

            #endregion
            #endregion
            #region Switch Expressions When
            /*
            int c = 10;
            string isim1 = c switch
            {
                5 when 3==3 => "Hilmi",
                var x when x == 7 && x % 2 == 1 => "Rıfkı", //buradaki i iyi var ilede tanımlayabiliriz veya i ye karşılık gelen türü ilede karşıyabiliriz örnek(int,string vb)
                10 => "Gençay"
            var x => "Hiçbiri" default: hiçbirinin olmadığı durumlarda gerçekleşir
            };
            */
            #endregion
            #region Tuple Patterns
            #region Eski Yöntem
            /*
           int s1 = 10;
           int s2 = 20;
           string mesaj1 = "";
           switch (s1,s2)
           {
               case (5  , 10):
                   mesaj1 = "5 ile 10 değerleri";
                   break;
               case (10 , 20):
                   mesaj1 = "10 ile 20 değerleri";
                   break;
               default:

                   break;
           }
           Console.WriteLine(mesaj1);
           */
            #endregion
            #region Yeni Yöntem
            /*
           int s1 = 10;
           int s2 = 20;
           string mesaj1 = (s1,s2) switch
            {
            (5,10) => "5 ile 10 değerleri",
            (10 , 20) => "10 ile 20 değerleri"
            }
           
           Console.WriteLine(mesaj1);
           */
            #endregion

            #endregion
            #region Tuple Patterns when Şartı Uygulamak
            /*
           int s1 = 10;
           int s2 = 20;
           string mesaj1 = (s1,s2) switch
            {
            (5,10) when (true) => "5 ile 10 değerleri",
            var x when x.s1 % 2 == 1 || x.s2 == 10 => "10 ile 20 değerleri"
            }
           
           Console.WriteLine(mesaj1);
           */
            #endregion
            Console.ReadLine();


        }
    }
}
