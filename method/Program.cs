using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
       static void verschil()
        {
            int   getal , get ; get = int.Parse(Console.ReadLine()); getal = int.Parse(Console.ReadLine());
            Console.WriteLine("het verschil is {0}", getal - get);
        }
        static void Main(string[] args)
        {
            verschil();
        }
    }
}
