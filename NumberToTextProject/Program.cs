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
                INumberToText numberToText = new NumberToTextEnglish();
                Console.WriteLine("\n\n-Metne dönüştürmek istediğiniz bir sayı giriniz. Programdan çıkmak için Exit yazınız.");
                var inputNumber = GetInputText();
                if (inputNumber != "CheckFailed" || inputNumber != "Exit")
                {
                    numberToText.ParseInputNumberThreeDigitGroup(inputNumber);
                    numberToText.BuildAllDigitsInNumber();
                }

                checkForExit = inputNumber;
            }
        }

        private static string GetInputText()
        {
            string inputNumber = "";
            inputNumber = Console.ReadLine();
            var checkResult = CheckInputNumber(inputNumber);

            if (!checkResult)
            {
                inputNumber = "CheckFailed";
            }
            return inputNumber;
        }

        public static bool CheckInputNumber(string inputNumber)
        {
            bool inputNumberCheckResult = true;
            if (string.IsNullOrEmpty(inputNumber) || string.IsNullOrWhiteSpace(inputNumber))
            {
                Console.WriteLine("-Boş giriş yapamazsınız. Lütfen bir sayı giriniz.");
                inputNumberCheckResult = false;
            }
            else if (!CheckInputNumberIsNumber(inputNumber))
            {
                Console.WriteLine("-Sayı harici karakter giremezsiniz. Lütfen bir sayı giriniz...");
                inputNumberCheckResult = false;
            }
            else if (inputNumber.Length > 36)
            {
                Console.WriteLine("-Daha küçük bir sayı giriniz. 36 basamağa kadar desteklenmektedir.");
                inputNumberCheckResult = false;
            }
            else
            {
                Console.WriteLine("-Girdiğiniz sayı: {0}", inputNumber);
            }

            return inputNumberCheckResult;
        }

        public static bool CheckInputNumberIsNumber(string inputNumber)
        {
            int counter = 0;
            foreach (var chr in inputNumber)
            {
                if (!Char.IsDigit(chr))
                {
                    counter++;
                }
            }
            if (inputNumber == "Exit")
            {
                counter = 0;
            }
            return counter.Equals(0);
        }
    }
}