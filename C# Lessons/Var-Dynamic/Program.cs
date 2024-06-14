using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region var keywordü
            //Diller arası entagrasyonda kullanıyordu.
            //değişkenin türünü kendimiz yazarsak daha az maliyetli olur.
            var adi = "Firat";//değişkeni oluşturduğumuz zaman değerini vermeliyiz hemen ki o türe dönüşsün.
                              //var-object arasındaki fark var bir keyword object ise bir türdür.var atanan değerin türüne bürünürken,object atanan değeri boxing yaparak objectte dönüştürür.






            #endregion

            #region dynamic keywordü
            dynamic a = 5;
            //var derleme asamasında değerin türüne bürünürken dynamic ise runtimeda verilen değerin türüne bürünecektir.
            //var hemen int oluyor ve int olarak kullanabiliyoruz ama dynamic int bir değer verildiğinde kendini runtimeda int olarak gösterir.
            Console.WriteLine(a.GetType());
            dynamic x = "Ahmet";
            Console.WriteLine(x.GetType());
            x = 3.12D;
            Console.WriteLine(x.GetType());
            Console.ReadLine();
            //dynamic var gibi değildir türü değişebilir.
            //uzaktan gelen türünü bilmediğimiz verileri dynamic keywordüyle karşılayabiliriz.
            //var ile uzaktan gelen veriyi karşılayamayız çünkü var tanımlandığı esnada verinin atanmasını ister.

            #endregion

        }
    }
}
