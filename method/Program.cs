using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
       static void kwad(ref int a)
        {
          
          Math.Sqrt(a); 
           if (Math.Sqrt(a) *Math.Sqrt(a) ==a);
            {
              Console.WriteLine("de opsoming van de uitkomst van het kwadraat is ");
            }
        }
        static void Main(string[] args)
        {
                int get ; 
            Console.WriteLine("geef je getal in "); get = int.Parse(Console.ReadLine());
            kwad(ref get);
           
        }
    }
}
