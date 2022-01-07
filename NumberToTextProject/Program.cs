using System;

namespace NumberToTextProject
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string checkForExit = "";

            while (checkForExit != "Exit")
            {
                NumberToText numberToText = new NumberToText();
                Console.WriteLine("\n\n-Metne dönüştürmek istediğiniz bir sayı giriniz. Çıkmak için Exit yazınız.");
                var inputNumber = GetInputText();
                numberToText.ParseInputNumberThreeDigitGroup(inputNumber);
                numberToText.BuildAllDigitsInNumber();
                checkForExit = inputNumber;
            }
        }

        private static string GetInputText()
        {
            string inputNumber = "";
            inputNumber = Console.ReadLine();

            CheckInputNumber(inputNumber);

            return inputNumber;
        }

        public static void CheckInputNumber(string inputNumber)
        {
            if (string.IsNullOrEmpty(inputNumber) || string.IsNullOrWhiteSpace(inputNumber))
            {
                Console.WriteLine("-Boş giriş yapamazsınız. Lütfen bir sayı giriniz.");
            }
            else if (!CheckInputNumberForDigits(inputNumber))
            {
                Console.WriteLine("-Sayı harici karakter giremezsiniz. Lütfen bir sayı giriniz...");
            }
            else if (inputNumber.Length > 36)
            {
                Console.WriteLine("-Daha küçük bir sayı giriniz. 36 basamağa kadar desteklenmektedir.");
            }
            else
            {
                Console.WriteLine("-Girdiğiniz sayı: {0}", inputNumber);
            }
        }

        public static bool CheckInputNumberForDigits(string inputNumber)
        {
            int counter = 0;
            foreach (var chr in inputNumber)
            {
                if (!Char.IsDigit(chr))
                {
                    counter++;
                }
            }

            return counter.Equals(0);
        }
    }
}