using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foutopdrachten1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                int[] reeks  = new int[3];
              
            for ( int i = 0; i < 4 ; i++)
            {
              reeks[i] = i ;
              
            }
            }
            catch (IndexOutOfRangeException)
            { 
                Console.WriteLine("out of range");
             }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
            }
         
        }
    }
}
