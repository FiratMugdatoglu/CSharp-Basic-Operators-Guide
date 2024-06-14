using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sayısal İfadelerin Knedi Aralarında Tür Dönüşümü
            #region Bilinçsiz Tür Dönüşümü
            //kendinden büyük bir türe dönüştürmeye çalıştığımızda bilinçsiz tür dönüşümü denir.
            int a = 3000;
            float f = a;

            short x = 21;
            long l = x;

            #endregion
            #region Bilinçli Tür Dönüşümü
            //kendinden küçük bir türe dönüştürmeye çalıştığımızda bilinçli tür dönüşümü denir.

            int y = 3000;
            short y1 = (short)y;
            Console.WriteLine(y1);



            int z = 3000;
            short z1= (byte)z;//burda z sayısını byte dönüştürerek bilinçli sayıyı dönüştürüp shorta ataması bilinçsiz duruma örnektir.

            #endregion
            #region checked
            //Bilinçli tür döngüsü esnasında veri kaybı söz konusu olursa runtime'da bizleri uyaracak olan kontrol mekanizmasıdır.
            int k = 3000;
            byte k1 = (byte)k;
            Console.WriteLine(k1);
            #endregion
            #region unchecked
            //Bilinçli tür döngüsü esnasında veri kaybı söz konusu olursa runtime'da bizleri uyarmaz.
            //Normal kod bloğuda aynı işlemi yapıyor.
            #endregion
            #region kritik

            #endregion
            #endregion



            Console.ReadLine();














        }
    }
}
