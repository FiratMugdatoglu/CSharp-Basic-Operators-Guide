using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders6
{
    internal class Program
    {
        static void Main(string[] args)
        {




            #region Ternary Operatorü

            #region Tanıtım
            bool medeniHal = false;
            string mesaj = medeniHal ? "Evlilere Kampanya" : "Bekarlara Kampanya";
            Console.WriteLine(mesaj);


            //Yaşı 25'den küçükse A 25 ise B 25'ten büyük ise C dönsün.
            int yas = 25;
            string sonuc = yas < 25 ? "A" : (yas == 25 ? "B" : "C");
            Console.WriteLine(sonuc);
          
            #endregion
            #region Örnek1

            //Kullanıcı tarafından girilen sayının aşağıdaki önergelere göre hesabını gerçekleştiren kodu geliştiriniz.
            //sayı < 3  => sayı*5
            //sayı > 3  && sayı < 9  => sayı * 3
            //sayı >= 9 && sayi % 2 == 0  => sayı * 10
            //sayı % 2 == 1   => sayı
            //hiçbiri değilse   => -1


            Console.Write("Lütfen bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());//ReadLine kullanıcıdan değer almamızı sağlar ama aldığımız değeri string döndürür.O yüzden int.parse ile int dönüştürüp integera atıyoruz.
            
            int sonuc1 = sayi < 3 ? sayi * 5 :
                (sayi > 3 && sayi < 9 ? sayi * 3 :
                (sayi >= 9 && sayi % 2 == 0 ? sayi * 10 : 
                (sayi % 2 == 1 ? sayi : -1)));

            Console.WriteLine(sonuc1);



            #endregion
            #region Örnek2


            //Hava durumunu tutan string değişkenin değerine göre aşağıdaki önergeleri uyguluyan programı yazınız
            // "Yağmurlu" => "Şemsiye almalısın"
            // "Güneşli"  => "Bol bol d vitamini alman dileğiyle.."
            // "Kapalı"   => "Yağmur yağabilir"

            string havaDurumu = "Güneşli";

            Console.WriteLine(havaDurumu == "Yağmurlu" ? "Şemsiye almalısın" : (havaDurumu == "Güneşli" ? "Bol bol d vitamini alman dileğiyle.." : "Yağmur yağabilir"));
            Console.ReadLine();
            #endregion

            #endregion












        }
    }
}
