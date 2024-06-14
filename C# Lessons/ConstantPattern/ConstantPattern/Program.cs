using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Constant Pattern
            object x = 123;
            if (x is 123)
            {
                Console.WriteLine("x 123'tür");
            }
            if (x is int)
            {
                Console.WriteLine("x int'dır");
            }
            if (x is bool)
            {
                Console.WriteLine("x bool'yındır");
            }
            #endregion
            #region Constant Patter Kritik
            //is operatörü bir değişkenin türünü sormamızı sağlayan bir operatördür.Ve bu operatörün kullanıldığı değişkenleri türü illa bir referans türlü olmak zorunda değildir.
            //İsterseniz değer türlü değişkenlerde de is operatörü kullanılabilmektedir.Ve hatta primitive türlerde bile kullanılabilmektedir.

            int a = 5;
            Console.WriteLine(a is int);
            Console.WriteLine(a is string);//Buradakiler ise normal is operatörünün kendi fıtratındaki işlemdir.

            Console.WriteLine(a is 5);//Eğer ki is operatörüyle bir değişkenin değerini == operatörünün sorumluluğuyla check ediyorsa işte buna Constant Pattern denmektedir.
            



            #endregion
            Console.ReadLine();
        }
    }
}
