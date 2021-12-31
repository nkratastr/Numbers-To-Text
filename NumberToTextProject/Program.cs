using System;

namespace NumberToTextProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GetInputText();
        }

        private static void GetInputText()
        {
            string inputNumber = "";
            inputNumber = Console.ReadLine();

            Program program = new Program();
            program.CheckInputNumber(inputNumber);
        }

        public void CheckInputNumber(string inputNumber)
        {
            if (string.IsNullOrEmpty(inputNumber) || string.IsNullOrWhiteSpace(inputNumber))
            {
                Console.WriteLine("Boş giriş yapamazsınız. Lütfen bir sayı giriniz.");
                Program.GetInputText();
            }
            else if (!CheckInputNumberForDigits(inputNumber))
            {
                Console.WriteLine("Sayı harici karakter giremezsiniz. Lütfen bir sayı giriniz...");
                Program.GetInputText();
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı: {0}", inputNumber);
            }
        }

        public bool CheckInputNumberForDigits(string inputNumber)
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