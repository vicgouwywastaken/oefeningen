using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method5
{
    class Program
    {
        static void Main(string[] args)
        {
            short gem;
            gem = 0;
            Console.WriteLine("wil je het gemiddelde berekenen");string antw =  Console.ReadLine();
            switch (antw)
            {
                case "y":
                    Keuze(ref gem);
                    break;
                case "yes":
                    Keuze(ref gem);
                    break;
                case "ja":
                    Keuze(ref gem);
                    break;
                case "j":
                    Keuze(ref gem);
                    break;
            }
           
            
         }
       static void Keuze(ref short a )
        {

        } 
        static void gemiddelde(ref short gem)
        {

        }
     }
}
