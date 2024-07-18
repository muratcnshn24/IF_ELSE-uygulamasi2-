using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_uygulamasi2_
{
    class Program
    {
        static void Main(string[] args)
        {

            bool result = true;

            // başına ! işareti koyarsak else bloğu çalışacak.
            if (!result) 
            {
                Console.WriteLine("Sonuc1");
            }
            else
            {
                Console.WriteLine("Sonuc2");
            }

        }
    }
}
