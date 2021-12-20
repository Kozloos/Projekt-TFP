using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
\mainpage Hlavní stránka - Morseovka

Toto je hlavní stránka projektu Morseovka do předmětu AP1VS

Program dokáže převést zadanou abecední zprávu na morseovy znaky. Dále dokáže převést z morseových znaků na znaky abecedy.


//@author Filip Frýdl
//@author Patrick Trampota
//@author Tomáš Kozlíček

//@date 18.12.2021

*/

namespace morseovka_zkouska
{
    ///@brief Třída Morseovka
    ///@brief Tato třída slouží k zjednodušení programu
    ///@brief V této třídě se nachází 6 metod
    public class Morseovka
    {

        ///@brief Metoda, která vrátí a vypíše zadanou morseovu zprávu
        ///@param l - Zpráva získaná zadáním z klávesnice 
        ///@return s - vrátí převzatou zprávu 
        public string VraceniMorseovyZpravy(string l)
        {
            string s = l;
            
            Console.WriteLine($"Původní zpráva: {s}");
            
            return s;
        }

        ///@brief Metoda, která vrátí pole jednotlivých morseových znaků   
        ///@param s - Zadaná zpráva, získaná z klávesnice
        ///@return znaky - Pole znaků získané rozdělením řetězce s na jednotlivé znaky
        
        public string[] RozbitiMorseovyZpravy(string s)
        {
            string[] znaky = s.Split(new char[] { ' ' });
            return znaky;
        }

        
        ///@brief Metoda, která překóduje morseovy znaky na abecední znaky pomocí cyklu foreach
        ///@param abecedniZnaky - Všechny znaky abecedy 
        ///@param morseovyZnaky - Všechny morseovy znaky
        ///@param znaky - Jednotlivé znaky získané ze zadané zprávy 
        ///@return zprava - Překódovaná abecední zpráva 
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

        ///@brief Metoda, která vrátí a vypíše zadanou abecední zprávu
        ///@param l - Zpráva získaná zadáním z klávesnice 
        ///@return s - vrátí převzatou zprávu 
        public string VraceniAbecedniZpravy(string r)
        {
            string s = r;

            //Vypsání původní zprávy
            Console.WriteLine($"Původní zpráva: {s}");

            return s;
        }

        ///@brief Metoda, která vrátí pole jednotlivých abecedních znaků pomocí cyklu for    
        ///@param z - Zadaná zpráva, získaná z klávesnice
        ///@return pismena - Pole písmen získané rozdělením řetězce 
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


        ///@brief Metoda, která překóduje abecední znaky na morseovy znaky pomocí cyklu foreach
        ///@param abecedniZnaky - Všechny znaky abecedy 
        ///@param morseovyZnaky - Všechny morseovy znaky
        ///@param pismena - Jednotlivá písmena získaná ze zadané zprávy 
        ///@return zprava2 - Překódovaná morseova zpráva 
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

     
    ///@brief Třída Program je hlavní část programu
    ///@brief Slouží k tomu, aby program správně fungoval a byl možný spustit 
    ///@brief Nachází se zde deklarace polí, jednoduché menu a jsou zde užity všechny metody ze třídy Morseovka
    class Program
    {
        static void Main(string[] args)
        {
            
            //Pole s abecedními znaky a druhé pole s morseovými znaky
            string[] abecedniZnaky = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t",
                                      "u","v","w","x","y","z"};

            string[] morseovyZnaky = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
            "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
            "...-", ".--", "-..-", "-.--", "--.."};

            string volba;

            //Cyklus do-while, který slouží k vypsání menu
            //Dovoluje uživateli vybrat možnost překódování
            do
            {
                //Jednoduché menu
                Console.Clear();
                Console.WriteLine("1 - Z morseova kódu na abecedu");
                Console.WriteLine("2 - Z abecedy na morseův kód");
                Console.WriteLine("0 - konec");
                Console.WriteLine(" ");
                Console.Write("Zadej možnost: ");
                volba = Console.ReadLine();

                //Cyklus switch, který vykoná zadanou možnost od uživatele 
                switch (volba)
                {
                    //Ukončí program
                    case "0":
                        break;

                    //Možnost 1 překóduje z morseových znaků na znaky abecedy
                    case "1":
                        Console.Clear();
                        Morseovka morseovka = new Morseovka();

                        
                        //Načtení morseovy zprávy
                        Console.WriteLine("Zadej morseův kód: ");
                        string l = Console.ReadLine();

                        //Vyprázdnění konzole
                        Console.Clear();
                        string s = morseovka.VraceniMorseovyZpravy(l);
                        string[] znaky = morseovka.RozbitiMorseovyZpravy(s);
                        string zprava = morseovka.VraceniPrekodovaneZpravy(abecedniZnaky, morseovyZnaky, znaky);

                        //Vypsání výsledné překódované zprávy
                        Console.WriteLine($"Abecední zpráva: {zprava}");
                        Console.ReadKey();

                        break;

                    //Možnost 2 překóduje z abecedních znaků na morseovy znaky
                    case "2":

                        Console.Clear();
                        Morseovka morseovka1 = new Morseovka();

                        Console.WriteLine("Zadej abecední kód: ");
                        string s2 = Console.ReadLine();
                        Console.Clear();

                        string z = morseovka1.VraceniAbecedniZpravy(s2);
                        string[] pismena = morseovka1.ZiskSamostatnychPismen(z);
                        string zprava2 = morseovka1.PrevedeniZAbecedyNaMorseovku(abecedniZnaky,morseovyZnaky,pismena);

                        //Vypsání výsledné překódované zprávy
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
