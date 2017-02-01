using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Teht_v_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna vuosi > ");
            string rivi = Console.ReadLine();
            int vuosi;
            bool result = Int32.TryParse(rivi, out vuosi);
            if (result)
            {
                if ((vuosi % 4 == 0 && vuosi % 100 != 0) || vuosi % 400 == 0)
                {
                    Console.WriteLine("Vuosi on karkausvuosi.");
                }
                else
                {
                    Console.WriteLine("Vuosi ei ole karkausvuosi.");
                }
            }
            else
            {
                Console.WriteLine("Et antanut numeroa!");
            }
            Console.ReadLine();
        }
    }
}
