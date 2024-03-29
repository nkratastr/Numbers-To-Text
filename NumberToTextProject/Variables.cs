﻿using System.Collections.Generic;

namespace NumberToTextProject
{
    public class Variables
    {
        public char[] MainDigits = new char[] { '0', '0', '0' };
        public string threeDigitTextVersion;
        public string[] digitsOrderedByAscending = new string[12];


        public string[] DigitsInInputNumberTurkish = new string[] { "", "Bin", "Milyon", "Milyar", "Trilyon", "Katrilyon", "Kentilyon", "Seksilyon", "Septilyon", "Oktilyon", "Nobilyon", "Desilyon" };
        public IDictionary<char, string> OneToNineDigitTurkish = new Dictionary<char, string> { { '1', "Bir" }, { '2', "İki" }, { '3', "Üç" }, { '4', "Dört" }, { '5', "Beş" }, { '6', "Altı" }, { '7', "Yedi" }, { '8', "Sekiz" }, { '9', "Dokuz" } };
        public IDictionary<char, string> TenToNinetyDigitTurkish = new Dictionary<char, string> { { '1', "On" }, { '2', "Yirmi" }, { '3', "Otuz" }, { '4', "Kırk" }, { '5', "Elli" }, { '6', "Altmış" }, { '7', "Yetmiş" }, { '8', "Seksen" }, { '9', "Doksan" } };
        public IDictionary<char, string> OneHunderedToNineHunderedDigitTurkish = new Dictionary<char, string> { { '1', "Yüz" }, { '2', "İkiYüz" }, { '3', "ÜçYüz" }, { '4', "DörtYüz" }, { '5', "BeşYüz" }, { '6', "AltıYüz" }, { '7', "YediYüz" }, { '8', "SekizYüz" }, { '9', "DokuzYüz" } };

        public string[] DigitsInInputNumberEnglish = new string[] { "", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion", "Sextillion", "Septillion", "Octillion", "Nobillion", "Decillion" };
        public IDictionary<char, string> OneToNineDigitEnglish = new Dictionary<char, string> { { '1', "One" }, { '2', "Two" }, { '3', "Three" }, { '4', "Four" }, { '5', "Five" }, { '6', "Six" }, { '7', "Seven" }, { '8', "Eight" }, { '9', "Nine" } };
        public IDictionary<char, string> TeensEnglish = new Dictionary<char, string> { { '0', "Ten" }, { '1', "Eleven" }, { '2', "Twelwe" }, { '3', "Thirteen" }, { '4', "Fourteen" }, { '5', "Fifteen" }, { '6', "Sixteen" }, { '7', "Seventeen" }, { '8', "Eighteen" }, { '9', "Nineteen" } };
        public IDictionary<char, string> TenToNinetyDigitEnglish = new Dictionary<char, string> { { '1', "" }, { '2', "Twenty" }, { '3', "Thirty" }, { '4', "Forty" }, { '5', "Fifty" }, { '6', "Sixty" }, { '7', "Seventy" }, { '8', "Eighty" }, { '9', "Ninety" } };
        public IDictionary<char, string> OneHunderedToNineHunderedDigitEnglish = new Dictionary<char, string> { { '1', "OneHundred" }, { '2', "TwoHundred" }, { '3', "ThreeHundred" }, { '4', "FourHundred" }, { '5', "FiveHundred" }, { '6', "SixHundred" }, { '7', "SevenHundred" }, { '8', "EightHundred" }, { '9', "NineHundred" } };

        //public bool checkUseOfEnInDutch = false;
        public string[] DigitsInInputNumberDutch = new string[] { "", "Duizend", "Miljoen", "Miljard", "Triljoen", "Quadriljoen", "Quintiljoen", "Secstiljoen", "Septiljoen", "Octiljoen", "Nobiljoen", "Deciljoen" };
        public IDictionary<char, string> OneToNineDigitDutch = new Dictionary<char, string> { { '1', "Een" }, { '2', "Twee" }, { '3', "Drie" }, { '4', "Vier" }, { '5', "Vijf" }, { '6', "Zes" }, { '7', "Zeven" }, { '8', "Acht" }, { '9', "Negen" } };
        public IDictionary<char, string> TeensDutch = new Dictionary<char, string> { { '0', "Tien" }, { '1', "Elf" }, { '2', "Twaalf" }, { '3', "Dertien" }, { '4', "Veerteen" }, { '5', "Vijfteen" }, { '6', "Zesteen" }, { '7', "Zeventeen" }, { '8', "Achteen" }, { '9', "Negenteen" } };
        public IDictionary<char, string> TenToNinetyDigitDutch = new Dictionary<char, string> { { '1', "" }, { '2', "Twintig" }, { '3', "Dirtig" }, { '4', "Viertig" }, { '5', "Vijftig" }, { '6', "Zestig" }, { '7', "Zeventig" }, { '8', "Tachtig" }, { '9', "Negentig" } };
        public IDictionary<char, string> OneHunderedToNineHunderedDigitInDutch = new Dictionary<char, string> { { '1', "Honderd" }, { '2', "Tweehonderd" }, { '3', "Driehonderd" }, { '4', "Vierhonderd" }, { '5', "Vijfhonderd" }, { '6', "Zeshonderd" }, { '7', "Zevenhonderd" }, { '8', "Achthonderd" }, { '9', "Negenhonderd" } };

        public string[] DigitsInInputNumberSpanish=new string[] { "", "Mil", "Millón", "Mil Millones", "Billón", "Mil Billones", "Trillón", "Mil Trillones", "Cuatrillón", "Mil Cuatrillones", "Quintillón", "Mil Quintillones" };

        public string[] DigitsInInputNumberFrench = new string[] { "", "Mille", "Million", "Milliard", "Billion", "Billiard", "Trillion", "Trilliard", "Quadrillion", "Quadrilliard", "Quintillion", "Quintilliard" };
        public IDictionary<char, string> OneToNineDigitFrench = new Dictionary<char, string> { { '1', "Un" }, { '2', "Deux" }, { '3', "Trois" }, { '4', "Quatre" }, { '5', "Cinq" }, { '6', "Six" }, { '7', "Sept" }, { '8', "Huit" }, { '9', "Neuf" } };
        public IDictionary<char, string> TeensFrench = new Dictionary<char, string> { { '0', "Dix" }, { '1', "Onze" }, { '2', "Douze" }, { '3', "Treize" }, { '4', "Quatorze" }, { '5', "Quinze" }, { '6', "Seize" }, { '7', "DixSept" }, { '8', "DixHuit" }, { '9', "DixNeuf" } };
        public IDictionary<char, string> TenToNinetyDigitFrench=new Dictionary<char, string> { { '1', "" }, { '2', "Vingt" }, { '3', "Trente" }, { '4', "Quarante" }, { '5', "Cinquante" }, { '6', "Soixante" }, { '7', "SoixanteDix" }, { '8', "QuatreVingt" }, { '9', "QuatreVingtDix" } };
        public IDictionary<char, string> OneHunderdToNineHunderedDigitInFrench= new Dictionary<char, string> { { '1', "Cent" }, { '2', "DeuxCent" }, { '3', "TroisCent" }, { '4', "QuatreCent" }, { '5', "CinqCent" }, { '6', "SixCent" }, { '7', "SeptCent" }, { '8', "HuitCent" }, { '9', "NeufCent" } };


        

    }
}