using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morseovka_finalni
{
class Morseovka
    {
        public string VraceniMorseovyZpravy()
        {
            Console.Clear();
            //Načtení morseovy zprávy
            Console.WriteLine("Zadej morseův kód: ");
            string s = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Původní zpráva: {s}");
            
            return s;
        }

        public string[] RozbitiMorseovyZpravy(string s)
        {
            string[] znaky = s.Split(new char[] { ' ' });
            return znaky;
        }

        public string VraceniPrekodovaneZpravy(string[] abecedniZnaky, string[] morseovyZnaky, string[] znaky)
        {
            string zprava = "";

            foreach (string morseuvZnak in znaky)
            {
                string abecedniZnak = " ";
                int index = Array.IndexOf(morseovyZnaky, morseuvZnak);
                if (index >= 0)
                {
                    abecedniZnak = abecedniZnaky[index];
                }
                zprava += abecedniZnak;
            }

            return zprava;
        }

        public string VraceniAbecedniZpravy()
        {

            //Načtení abecední zprávy
            Console.WriteLine("Zadej abecední kód: ");
            string s = Console.ReadLine();
            Console.Clear();

            //Vypsání původní zprávy
            Console.WriteLine($"Původní zpráva: {s}");

            return s;
        }

        public string[] ZiskSamostatnychPismen(string z)
        {
            //Vložení samostatných písmen do pole
            string[] pismena = new string[z.Length];

            for (int i = 0; i < z.Length; i++)
            {
                string pismeno = z.Substring(i, 1);
                pismena[i] = pismeno;
            }

            return pismena;
        }

        public string PrevedeniZAbecedyNaMorseovku(string[] abecedniZnaky, string[] morseovyZnaky, string[] pismena)
        {
            string zprava2 = "";

            foreach (string abecedniZnak in pismena)
            {
                string morseuvZnak = " ";

                int index = Array.IndexOf(abecedniZnaky, abecedniZnak);
                if (index >= 0)
                {
                    morseuvZnak = morseovyZnaky[index];
                }
                zprava2 += morseuvZnak + " ";
            }
            return zprava2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Pole s abecedními znaky a druhé pole s morzeovými znaky
            string[] abecedniZnaky = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t",
                                      "u","v","w","x","y","z"};

            string[] morseovyZnaky = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
            "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
            "...-", ".--", "-..-", "-.--", "--.."};

            string volba;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Z morseova kódu na abecedu");
                Console.WriteLine("2 - Z abecedy na morseův kód");
                Console.WriteLine("0 - konec");
                Console.WriteLine(" ");
                Console.Write("Zadej možnost: ");
                volba = Console.ReadLine();

                switch (volba)
                {
                    case "0":
                        break;


                    case "1":
                        Console.Clear();
                        Morseovka morseovka = new Morseovka();
                        
                        string s = morseovka.VraceniMorseovyZpravy();
                        string[] znaky = morseovka.RozbitiMorseovyZpravy(s);
                        string zprava = morseovka.VraceniPrekodovaneZpravy(abecedniZnaky, morseovyZnaky, znaky);

                        Console.WriteLine($"Abecední zpráva: {zprava}");
                        Console.ReadKey();

                        break;

                    case "2":

                        Console.Clear();
                        Morseovka morseovka1 = new Morseovka();

                        string z = morseovka1.VraceniAbecedniZpravy();
                        string[] pismena = morseovka1.ZiskSamostatnychPismen(z);
                        string zprava2 = morseovka1.PrevedeniZAbecedyNaMorseovku(abecedniZnaky,morseovyZnaky,pismena);

                        Console.WriteLine($"Abecední zpráva: {zprava2}");
                        Console.ReadKey();

                        break;


                }
            }
            while (volba != "0");
            Console.ReadKey();


        }
    }
}
