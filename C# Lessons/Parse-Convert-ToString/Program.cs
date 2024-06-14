using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Metinsel İfadelerin Diğer İfadelere Dönüştürülmesi
            //Tür dönüşümlerinde dikkat edilmesi gereken tek bir husus vardır ki, o da ; dönüşüm yapılacak verinin türüne uygun bir hedef tür belirlenmelidir.
            #region Parse Metodu
            //Pars metodu sadece string dataları hedef türe dönüştürürken kullanılır.
            string x = "123";
            short x2 = short.Parse(x);
            Console.WriteLine(x2 * 5);

            string medeniHal = "true";
            bool medeniHal2 = bool.Parse(medeniHal);
            Console.WriteLine(medeniHal2);

            string y = "a";
            char y2 = char.Parse(y);
            Console.WriteLine(y2);

            
            #endregion
            #region Convert Fonksiyonları
            //Bir tek metinsel değil her türlü değişkeni diğer değişkene dönüştürebilir en başta verdiğimiz hususa uygunsa.
            string a = "25";
            int a2 = Convert.ToInt32(a);
            Console.WriteLine(a2);

            int b = 2524;
            string b2 = Convert.ToString(b);
            Console.WriteLine(b2);

            string c = "3,14";
            double c2 = Convert.ToDouble(c);
            Console.WriteLine(c2);

           
            #endregion
            #region ToString
            //Sadece metinsel ifadelere dönüştürmek için kullanılır.Bütün türleri stringe dönüştürebeliriz.
            float f = 25;
            string f2 = f.ToString();
            Console.WriteLine(f2);

            Console.ReadLine();
            #endregion
            #endregion











        }
    }
}
