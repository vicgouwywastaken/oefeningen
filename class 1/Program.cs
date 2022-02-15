using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("stopwatch druk op enter om te beginnen");
            Console.ReadLine();
            DateTime sdb = DateTime.Today ;
            Console.WriteLine("stopwatch druk op enter om te stoppen");
            Console.ReadLine();
            TimeSpan voorbij = new TimeSpan(sdb.Ticks - DateTime.Today.Ticks);
            Console.WriteLine("seconden gepaseerd is {0}", voorbij);
        }
    }
}
