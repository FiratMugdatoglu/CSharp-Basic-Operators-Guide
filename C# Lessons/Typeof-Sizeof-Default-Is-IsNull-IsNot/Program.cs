using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region typeof Operatörü
            Console.WriteLine("typeof Operatörü");


            //typeof operatörü verilen türün/değerin typenı/türünü getirir.
            //O tür ile ilgili bilgileri edinmek için kullanılan bir operatördür
            //İleride reflection dediğimiz bir konuda elimizdeki bir türün reflectionına girmek için kullanıldığını göreceğiz

            Type t = typeof(int);// int türüne ait tüm bilgileri burada t değişkenine atanmıştır.
            Console.WriteLine(t.Name);
            Console.WriteLine(t.IsPrimitive);
            Console.WriteLine(t.IsClass);
            Console.WriteLine(t.IsValueType);

            Console.WriteLine("\n\n\n\n\n");
            #endregion

            #region sizeof Operatörü
            Console.WriteLine("sizeof Operatörü");
            //Verilen türün bellekte kaç bytelık yer kapladığının int olarak geriye döndürür.
            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("decimal : " + sizeof(decimal));
            Console.WriteLine("\n\n\n\n\n");
            #endregion

            #region default Operatörü
            Console.WriteLine("default Operatörü");
            //Belirtilen türün default değerini döndüren operatördür..
            //Default değer ne demektir?Default değerler , her tür için yazılım tarafında tanımlanmış bir varsayıla değer demektir
            //sayisal = 0
            //bool = false
            // string = null
            //char = \0
            //referans = null

            Console.WriteLine(default(decimal));
            Console.WriteLine(default(Program));
            Console.WriteLine(default(string));
            Console.WriteLine(default(short));

            int a = default;
            int a1 = default(int);

            Console.WriteLine("\n\n\n\n\n");

            #endregion

            #region is Operatörü
            Console.WriteLine("is Operatörü");
            //Boxinge tabi tutulmuş bir değerin öz türünü öğrenebilmek /check edebilmek/kontrol edebilmek için kullanılan bir operatör
            //is operatörü denetleme neticesinde durumu bool yani true ya da false olarak döndürecektir

            object x = false;//Boxing
            Console.WriteLine(x is bool);
            Console.WriteLine(x is int);
            Console.WriteLine(x is Program);

            //İleride if yapılanmasında vs. çok tercih ettiğimiz bir operatör olucaktır.
            //OPP yapılanmasında polimorfizm is operatörüyle kalıtımsal durumlardaki nesnelerin türlerinede öğrenebileceğiz.


            Console.WriteLine("\n\n\n\n\n");
            #endregion

            #region is null
            Console.WriteLine("is null Operatörü");
            //Bir değişkenin değerinin null olup olmamasını kontrol edene ve sonuç olarak geriye bool türde bir değer döndüren operatördür.
            string z = null;
            Console.WriteLine(z is null);

            //is null operatörünü sadece null olabilen türlerde kullanabilmekteyiz.


            Console.WriteLine("\n\n\n\n\n");
            #endregion

            #region is not null Operatörü
            Console.WriteLine("is not null Operatörü");
           //Elimizdeki değerin null olup olmamasıyla ilgilenmekte ve geriye bool sonuç döndürmektedir.

           // string w = null;
            //Console.WriteLine(w is not null);

            //Sadece null alabilen türlerde kullanılabilir.






            Console.WriteLine("\n\n\n\n\n");
            #endregion



            Console.ReadLine();
        }
    }
}
