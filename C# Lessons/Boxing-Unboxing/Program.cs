using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region object
            #region Boxing
            //object türdeki bir değişkene herhangibi bir türdeki değeri göndermek Boxing olarak nitelendirilir.

            int yas = 28;
            object _yas = 28;//Object türünden verdiğimiz için matematiksel işlemler yapılamaz.Unboxing yapıldığında yapılabilir.


            #endregion
            #region Cast Operatörü

            //Boxing edilmiş veriyi kendi türünde elde etmemizi sağlayan operatördür.
            //  Cast Operatörü '()' dür.
            //Cast operatörü object olan değişkenin solunda o object'i hangi ture Unboxing etmek istiyorsak parantez içerisine hedef turu bildirerek kullanilir.
            int x = 5;
            object y = x;
            int j = (int)y;//Cast operatörü



            #endregion
            #region unBoxing
            int z = 5;
            object a = z;
            int v = (int)a;
            //unBoxing ettik.


            #endregion
            #endregion



            

        }
	}
}
