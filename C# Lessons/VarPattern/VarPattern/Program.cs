using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Var Pattern
            object x = "Fırat";
            if (x is var xx)
            {
                //var'ın kullanılma amacı x'in türünü bilmediğimiz zamanlarda var'a atarız var verilen türe bürünebiliyor ama bunu runtimeda yapıyor.
                //var normalde derleyeci sürecinde türü belirler ama buradaki var runtimede türü belirlerl.

                Console.WriteLine(xx);
            }


            #endregion
            Console.ReadLine();


        }
    }
}
