using Microsoft.VisualStudio.TestTools.UnitTesting;
using morseovka_zkouska; 


namespace Morseovka.UnitTest
{
    using morseovka_zkouska;

    [TestClass]
    public class MorseovkaTesty
    {
        

        [TestMethod]
        public void VraceniMorseovyZpravy_ZadanyRetezecZKonzole_StejnyRetezec()
        {
            var morseovka = new Morseovka();
            string l = "...";

            var vysledek = morseovka.VraceniMorseovyZpravy(l);

            Assert.AreEqual(l, vysledek);
        }

        [TestMethod]
        public void RozbitiMorseovyZpravy()
        {
            string s = "... --- ...";
            string[] expected = new string[]{ "...", "---", "..." };

            Morseovka morseovka1 = new Morseovka();
            var vysledek = morseovka1.RozbitiMorseovyZpravy(s);
            Assert.AreEqual(expected.ToString(),vysledek.ToString());
        }

        [TestMethod]
        public void VraceniPrekodovaneZpravy_PoleSPrvkyMorseovymiZnaky_RetezecAbecedniZnaky()
        {
            string[] abecedniZnaky = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t",
                                      "u","v","w","x","y","z"};

            string[] morseovyZnaky = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
            "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
            "...-", ".--", "-..-", "-.--", "--.."};

            string expected = "sos";

            Morseovka morseovka2 = new Morseovka();
            string[] znaky = new string[] {"...","---","..." };
            var result = morseovka2.VraceniPrekodovaneZpravy(abecedniZnaky, morseovyZnaky, znaky);
            Assert.AreEqual(expected, result.ToString());
        }

        [TestMethod]
        public void VraceniAbecedniZpravy_ZadanyText_VracenyRetezec()
        {
            Morseovka morseovka3 = new Morseovka();
            string expected = "sos";
            string result = morseovka3.VraceniAbecedniZpravy(expected);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ZiskSamostatnychPismen_ZadanyRetezec_JednotlivaPismena()
        {
            Morseovka morseovka4 = new Morseovka();
            string z = "ahoj";
            string[] expected = new string[] { "a", "h", "o", "j" };
            string[] result = morseovka4.ZiskSamostatnychPismen(z);
            Assert.AreEqual(expected.ToString(), result.ToString());
        }

        [TestMethod]
        public void PrevedeniZAbecedyNaMorseovku_PolePismen_MorseovyZnaky()
        {
            string[] abecedniZnaky = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t",
                                      "u","v","w","x","y","z"};

            string[] morseovyZnaky = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
            "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
            "...-", ".--", "-..-", "-.--", "--.."};

            string[] z = new string[] { "s", "o", "s" };
            string expected = "... --- ... ";

            Morseovka morseovka5 = new Morseovka();
            var result = morseovka5.PrevedeniZAbecedyNaMorseovku(abecedniZnaky, morseovyZnaky, z);
            Assert.AreEqual(expected, result.ToString());
        }
    }
}
