using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           #region Tuple Example

            (int a, int b) c = (5, 10);
            (int yas, string adi, bool medeniHal) kisi = (28, "Gençay", true);

            Console.WriteLine(c.a);
            Console.WriteLine(kisi.adi);


            (int z, string w) v = (5, "Fırat");
            Console.WriteLine(v.w);

           #endregion
           #region Literal Düzenlemeler
            int x = 1_000_000;//Sayılar arasında karmaşıklığı önlemek için '_' kullanılması yasak değil.
            Console.WriteLine(x);
           #endregion
           #region Değişken Türüne Özgü Default Değer Atamam
            //default keywordü:İçerisine verilen türün varsayılan değerini geri döndürür.
            bool z= default(bool);
            int y = default(int);
            Console.WriteLine(z);
           #endregion
           #region Default Literal
            //default içerisine türü yazmamıza gerek yok yeni gelen güncellemeyle.
            bool a= default;
            decimal j= default;
            #endregion
           #region Değişmezler/Sabitler(const)
            //Özünde statictir constlar ama constlarla verilen değerler değiştirilemezler
            const double pi = 3.14;//pi'nin değeri başka yerde değişemez bir daha ama okunabilir.Const kullandığımız yerde değeri hemen vermeliyiz.
           Console.WriteLine(pi);
           Console.ReadLine();
           #endregion



        }
    }
}
