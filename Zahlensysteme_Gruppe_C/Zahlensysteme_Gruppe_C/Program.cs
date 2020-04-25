using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zahlensysteme_Gruppe_C
{
    class Program
    {
        static string Eingabezahl,Eingabemodus;
        /// <summary>
        /// Zahlensysteme_Gruppe_C
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Titel");
            Console.WriteLine("Bitte Geben Sie die Binärzahl ein");         
            Eingabezahl = Console.ReadLine();
            Console.WriteLine("In welches Zahlensystem wollen sie ihre Zahl konvertieren?(Hex/Dec)");
            Eingabemodus = Console.ReadLine();

            Console.ReadKey();
        }

       
        }
    }
}
