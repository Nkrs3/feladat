using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cesar_kodolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToInt32('a'));  //Átalakítja a betűt karakterkóddá
            Console.WriteLine(Convert.ToChar(122));   //Számot alakítja betűvé

            /*Olvass be egy szót , mely csak az angol abc betűit trtalmazza! Az előbbieket
             * ellenőrizd és addig ismételd a beolvasást! Olvass be egy számot a [3,10]
             * intervallumban, ezt is ellenőrizd! A megadott szám segítségével végezd el a CesaR kódolást!
             * A kész kód nem léphet túl az angol abc betűin!
             */


            int eltolas = 0;
            int szam1;
            string p;
            string szo = String.Empty;
            string kodoltszo = string.Empty;
            do
            {
                Console.Write("Kérem az eltolás mértékét (3-10): ");
                int.TryParse(Console.ReadLine(), out eltolas);


            }
            while (eltolas < 3 || eltolas > 10);

                bool helytelenbemenet = false;
                do
                {
                    Console.Write("Kérem a kódolandó szót: ");
                    szo = Console.ReadLine();
                    for (int i = 0; i < szo.Length; i++)
                {
                    char betu = szo[i];
                    if (Convert.ToInt32(betu) < 97 || Convert.ToInt32(betu) > 122)
                    {
                        helytelenbemenet = true;
                    }
                }   

                } while (helytelenbemenet);

            foreach (char betu in szo)
            {
                int kod = Convert.ToInt32(betu) + eltolas;
                if (kod > 122)
                {
                    kod -= 26;
                }
                char kodoltetu = Convert.ToChar(kod);
                kodoltszo += kodoltetu;
             
            }
            Console.WriteLine("Kódolt szöveg: " + kodoltszo);

            
            

            
            

        }
    }
}
