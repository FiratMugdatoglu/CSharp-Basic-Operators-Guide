using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8__As_Operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region as Operatörü
            //Cast operatornun UnBoxing işlemine alternatif olarak üretilmiş bir operatördür
            //Cast operatöründe yanlışsa program çalışmaz ama as operatöründe yanlışsa null döndürür.
            #region Cast Örneklendirilmesi
            object x = "Ahmet";
            string x2 = (string)x;
            Console.WriteLine(x2);
          
            #endregion
            //As operatörününde çalışması için null alabilen türlerle çalışılması gerekir.
            object y = "Mehmet";
           string y1 = y as string;
            Console.WriteLine(y1);

            
            #endregion

            #region ?(Nullable) Operatörü

            //#C prog. dilinde değer türlü değişkenler normal şartlarda null değer alamazlar(Not nullable)
            //Bir değer türlü değişkenin null değer alabilmesi için(yani nullable olabilmesi için) ? operatörünün kullanılması gerekir.
            int? a = null;
            bool? b = null;
            Console.WriteLine(a is  null);
            Console.WriteLine(b);
            //Bir değer türü değişken nullable yapıldıysa eğer; is null,is not null, as gibi null ile açlışan operatörleri üzerinde kullanabiliriz.

            #region as Örneklendirme
            object w = 123;
            int? z = w as int?;
            Console.WriteLine(z);
            #endregion


            #endregion

            #region ??(Null-Coalescing) Operatörü
            //Elimizdeki değişkenin değerinin null olma durumuna istinaden farklı bir değeri göndermemizi sağlayan operatördür.
            string l = "Can";
            Console.WriteLine(l ?? "Merhaba");//Console.WriteLine(l == null ? "Merhaba" : l);ile aynı kod 
            string h = null;
            Console.WriteLine(h ?? "Merhaba");


            //Sol ve sağdaki türler birebir aynı olmalıdır.Aksi taktirde derleyici hata verecektir.
            #endregion

            #region ??= Operatörü (Null-Coalescing Assigment) (C# 8.0)
            string v = null;
            //Console.WriteLine(v ??= "Merhaba");//v'nin degeri null ise Merhaba yazdır ve Merhaba değerini v'ye ata.Eğer ki null değilse,direkt olarak v'nin değerini yazdıracaktır.
            #endregion

            Console.ReadLine();
        }
    }
}
