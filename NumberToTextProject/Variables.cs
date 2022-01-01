using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToTextProject
{
    public class Variables
    {
        public List<string> DigitsInInputNumber = new List<string> { "Bir", "Bin", "Milyon", "Milyar", "Trilyon", "Katrilyon" };
        public IDictionary<string, int> MainDigitsForConverter = new Dictionary<string, int> { { "Birler", 0 }, { "Onlar", 0 }, { "Yüzler", 0 } };
        public char[] MainDigits = new char[3] { '0', '0', '0' };
        public string finalTextForConsole;

        public IDictionary<char, string> OneToNineDigit = new Dictionary<char, string> { { '1', "Bir" }, { '2', "İki" }, { '3', "Üç" }, { '4', "Dört" }, { '5', "Beş" }, { '6', "Altı" }, { '7', "Yedi" }, { '8', "Sekiz" }, { '9', "Dokuz" } };

        //public IDictionary<string, int> OneToNineDigit = new Dictionary<string, int> { { "Bir", 1 }, { "İki", 2 }, { "Üç", 3 }, { "Dört", 4 }, { "Beş", 5 }, { "Altı", 6 }, { "Yedi", 7 }, { "Sekiz", 8 }, { "Dokuz", 9 } };
        public IDictionary<char, string> TenToNinetyDigit = new Dictionary<char, string> { { '1', "On" }, { '2', "Yirmi" }, { '3', "Otuz" }, { '4', "Kırk" }, { '5', "Elli" }, { '6', "Altmış" }, { '7', "Yetmiş" }, { '8', "Seksen" }, { '9', "Doksan" } };

        public IDictionary<char, string> OneHunderedToNineHunderedDigit = new Dictionary<char, string> { { '1', "Yüz" }, { '2', "İkiYüz" }, { '3', "ÜçYüz" }, { '4', "DörtYüz" }, { '5', "BeşYüz" }, { '6', "AltıYüz" }, { '7', "YediYüz" }, { '8', "SekizYüz" }, { '9', "DokuzYüz" } };
    }
}