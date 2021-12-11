using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morseovka_finalni
{
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
                        //Načtení morseovy zprávy
                        Console.WriteLine("Zadej morseův kód: ");
                        string s = Console.ReadLine();
                        Console.Clear();

                        //Vypsání původní zprávy
                        Console.WriteLine($"Původní zpráva: {s}");
                        string zprava = "";

                        //Rozbití původní zprávy na jednotlivé morseovy znaky
                        string[] znaky = s.Split(new char[] { ' ' });

                        //Převedení morzeových znaků na znaky abecedy
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

                        //Výpis zprávy převedené do abecedy
                        Console.WriteLine($"Abecední zpráva: {zprava}");
                        Console.ReadKey();

                        break;

                    case "2":

                        Console.Clear();
                        //Načtení abecední zprávy
                        Console.WriteLine("Zadej abecední kód: ");
                        s = Console.ReadLine();
                        Console.Clear();

                        //Vypsání původní zprávy
                        Console.WriteLine($"Původní zpráva: {s}");
                        string zprava2 = "";

                        //Vložení samostatných písmen do pole
                        string[] pismena = new string[s.Length];

                        for (int i = 0; i < s.Length; i++)
                        {
                            string pismeno = s.Substring(i, 1);
                            pismena[i] = pismeno;
                        }

                        //Převedení abecedy do morseových znaků
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
