using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToTextProject
{
    public class Variables
    {
        public char[] MainDigits = new char[] { '0', '0', '0' };
        public string threeDigitTextVersion;
        public string[] digitsOrderedByAscending = new string[12];

        public string[] DigitsInInputNumber = new string[] { "", "Bin", "Milyon", "Milyar", "Trilyon", "Katrilyon", "Kentilyon", "Seksilyon", "Septilyon", "Oktilyon", "Nobilyon", "Desilyon" };
        public IDictionary<char, string> OneToNineDigitTurkish = new Dictionary<char, string> { { '1', "Bir" }, { '2', "İki" }, { '3', "Üç" }, { '4', "Dört" }, { '5', "Beş" }, { '6', "Altı" }, { '7', "Yedi" }, { '8', "Sekiz" }, { '9', "Dokuz" } };
        public IDictionary<char, string> TenToNinetyDigitTurkish = new Dictionary<char, string> { { '1', "On" }, { '2', "Yirmi" }, { '3', "Otuz" }, { '4', "Kırk" }, { '5', "Elli" }, { '6', "Altmış" }, { '7', "Yetmiş" }, { '8', "Seksen" }, { '9', "Doksan" } };
        public IDictionary<char, string> OneHunderedToNineHunderedDigitTurkish = new Dictionary<char, string> { { '1', "Yüz" }, { '2', "İkiYüz" }, { '3', "ÜçYüz" }, { '4', "DörtYüz" }, { '5', "BeşYüz" }, { '6', "AltıYüz" }, { '7', "YediYüz" }, { '8', "SekizYüz" }, { '9', "DokuzYüz" } };

        public string[] DigitsInInputNumberEnglish = new string[] { "", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion", "Sextillion", "Septillion", "Octillion", "Nobillion", "Decillion" };
        public IDictionary<char, string> OneToNineDigitEnglish = new Dictionary<char, string> { { '1', "One" }, { '2', "Two" }, { '3', "Three" }, { '4', "Four" }, { '5', "Five" }, { '6', "Six" }, { '7', "Seven" }, { '8', "Eight" }, { '9', "Nine" } };
        public IDictionary<char, string> TeensEnglish = new Dictionary<char, string> { { '0', "Ten" }, { '1', "Eleven" }, { '2', "Twelwe" }, { '3', "Thirteen" }, { '4', "Fourteen" }, { '5', "Fifteen" }, { '6', "Sixteen" }, { '7', "Seventeen" }, { '8', "Eighteen" }, { '9', "Nineteen" } };
        public IDictionary<char, string> TenToNinetyDigitEnglish = new Dictionary<char, string> { { '1', "" }, { '2', "Twenty" }, { '3', "Thirty" }, { '4', "Forty" }, { '5', "Fifty" }, { '6', "Sixty" }, { '7', "Seventy" }, { '8', "Eighty" }, { '9', "Ninety" } };
        public IDictionary<char, string> OneHunderedToNineHunderedDigitEnglish = new Dictionary<char, string> { { '1', "OneHundred" }, { '2', "TwoHundred" }, { '3', "ThreeHundred" }, { '4', "FourHundred" }, { '5', "FiveHundred" }, { '6', "SixHundred" }, { '7', "SevenHundred" }, { '8', "EightHundred" }, { '9', "NineHundred" } };
    }
}