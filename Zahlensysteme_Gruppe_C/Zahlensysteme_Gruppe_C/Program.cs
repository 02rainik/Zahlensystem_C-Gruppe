using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zahlensysteme_Gruppe_C
{
    class Program
    {

        static string Eingabezahl,Eingabemodus, DecZahl;
      

        
        static int HexorDec = 0;

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
                HexorDec = HexoderDec(Eingabemodus);

            } while (HexorDec == 0);

            if (HexorDec == 1)
            {
                Console.WriteLine(BinToHex(Eingabezahl));
            }
            else if (HexorDec == 2)
            {
                Console.WriteLine(Dezimal(Eingabezahl));
            }
            Console.ReadKey();

            
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
        static int HexoderDec(string Auswahl) // 1 = HEX; 2 = DEC

        {
            if (Auswahl == "HEX")
                return 1;
            else if (Auswahl == "DEC")
                return 2;
            else
                return 0;                    
        }
        static string BinToHex(string Zahl)
        {
            string Hex = String.Format("{0:X4}", Convert.ToInt32(Zahl, 2));

            return Hex;
        }
        static string Dezimal(string Zahl)
        {
            DecZahl = Convert.ToInt32(Eingabezahl, 2).ToString();
            return (DecZahl);



        }

	}

}


