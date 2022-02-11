using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foutopdrachten2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = int.Parse("2147498545");
            }
             catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
             catch(ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
           
              catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
         }

    }
}
