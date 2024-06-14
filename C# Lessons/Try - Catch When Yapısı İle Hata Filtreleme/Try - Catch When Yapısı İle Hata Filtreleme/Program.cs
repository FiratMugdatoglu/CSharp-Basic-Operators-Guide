using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try___Catch_When_Yapısı_İle_Hata_Filtreleme
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region try - catch when Yapısı İle Hata Filtreleme
            //try catch bloklarına when keywordu ile şart uygulayabiliriz.
            try
            {
                int s1 = 0, s2 = 10;
                int a = s2 / s1;
            }
            catch (DivideByZeroException ex) when(3 == 3)
            {
                Console.WriteLine(ex.Message);
                
            }

            #endregion
            Console.ReadLine();



        }
    }
}
