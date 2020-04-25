using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zahlensysteme_Gruppe_C
{
    class Program
    {

        static string Eingabezahl,Eingabemodus, DecZahl;
      

        
        static int HexorBin = 0;

        /// <summary>
        /// Zahlensysteme_Gruppe_C
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Titel");
           do
            {
                Console.WriteLine("Bitte Geben Sie die Binärzahl ein");
                Eingabezahl = Console.ReadLine();

            } while (!(BinZahlTest(Eingabezahl)));


            do
            {

                Console.WriteLine("In welches Zahlensystem wollen sie ihre Zahl konvertieren?(Hex/Dec)");
                Eingabemodus = Console.ReadLine().ToUpper();
                HexorBin = HexoderBin(Eingabemodus);
            } while (HexorBin == 0);

            
        }
             

           static string Dezimal(string Zahl)
        {
            DecZahl = Convert.ToInt32(Eingabezahl, 2).ToString();
            return (DecZahl);     



        }

        static bool BinZahlTest(string BinZahl)
        {
            bool istdieZahlBin = true;
            for (int i = 0; i < BinZahl.Length; i++)
            {
                if (!(Convert.ToInt32(BinZahl.Substring(i, 1)) == 0 || Convert.ToInt32(BinZahl.Substring(i, 1)) == 1))
                {
                    istdieZahlBin = false;
                }
                
            }
            return istdieZahlBin;
        }


        static int HexoderBin(string Auswahl)
        {
            if (Auswahl == "HEX")
                return 1;
            else if (Auswahl == "DEX")
                return 2;
            else
                return 0;                    
        }

	}

}


