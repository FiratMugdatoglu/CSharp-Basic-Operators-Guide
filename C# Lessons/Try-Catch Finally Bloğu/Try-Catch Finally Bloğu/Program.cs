using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Finally_Bloğu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Finally Bloğu
            //Finally bloğu try-catch yapılanmasında hata alınsada alınmasada her iki durumda da çalıştırılması gereken kodları yazddığımız bloktur.
            try
            {
                Console.WriteLine("Try");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Catch");
                
            }
            finally 
            {
                
                Console.WriteLine("Finally");

            }


            #endregion

            Console.ReadLine();



        }
    }
}
