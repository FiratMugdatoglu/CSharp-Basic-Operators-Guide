using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Type Pattern
            //Bu zor olanı
            object x = "Gençay";
            if (x is string)
            {
                string xx = (string)x;
                Console.WriteLine(xx);
            }
            #endregion
            #region Type Pattern
            //Bu kolay olanı
            object y = "Gençay";
            if (y is string yy)
            {
                Console.WriteLine(yy);
            }
            // Buradaki yy yi dışarıda kullanamayız çünkü yukarıda y eğer string ise yy ye aktar diyoruz eğer string değilse aktarmyacaktır ondan.
            #endregion
            Console.ReadLine();
        }
    }
}
