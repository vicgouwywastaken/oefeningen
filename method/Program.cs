using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
       static void verschil(ref int a)
        {
            int   getal  ; 
            a = int.Parse(Console.ReadLine());
            getal = int.Parse(Console.ReadLine());
         a = a - getal ;
        }
        static void Main(string[] args)
        {
           int get ;
            get = 0 ;
          verschil(ref get );
            Console.WriteLine("het verschil is {0}", get);
           
        }
    }
}
