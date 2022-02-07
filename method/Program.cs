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
          int b ;
         b = (int)Math.Sqrt(a); 
           if (b *b  <=a)
            {
              Console.WriteLine("de uitkomst van het kwadraat is {0}", b );
                Console.WriteLine("de uitkomst van het kwadraat is {0} en de vermeningvuldiging is {1}en het orgineel getal is {2}", b , b *b , a );
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
