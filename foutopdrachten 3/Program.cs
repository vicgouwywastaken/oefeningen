using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foutopdrachten_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    arry();

                }
                catch ( IndexOutOfRangeException ex)
                {
                    Console.WriteLine("main out of range");
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

            }
        }
        static void arry()
        {
                try
                {
                    int[] reeks = new int[3];
                 
                    for (int i = 0; i < 4; i++)
                    {
                        reeks[i] = i;

                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("methode out of range");
                        throw new IndexOutOfRangeException("main out of range");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                        throw new Exception(e.Message);
                }
            
            Console.WriteLine("stopwatch druk op enter om te beginnen");
            Console.ReadLine();
        }
        }
    }
