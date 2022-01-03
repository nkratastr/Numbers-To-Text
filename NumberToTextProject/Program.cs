using System;

namespace NumberToTextProject
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var inputNumber = GetInputText();
            NumberToText numberToText = new NumberToText();
            numberToText.ParseInputNumberThreeDigitGroup(inputNumber);
            //char[] threeChar = numberToText.SetupThreeDigit(inputNumber.ToCharArray());
            //var finalText = numberToText.MatchDigitsToWriteConsole(threeChar);
            //.WriteLine("{0}", finalText);
            GetInputText();
            Console.ReadLine();
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
                Console.WriteLine("Boş giriş yapamazsınız. Lütfen bir sayı giriniz.");
                GetInputText();
            }
            else if (!CheckInputNumberForDigits(inputNumber))
            {
                Console.WriteLine("Sayı harici karakter giremezsiniz. Lütfen bir sayı giriniz...");
                GetInputText();
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı: {0}", inputNumber);
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