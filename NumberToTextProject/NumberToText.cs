using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToTextProject
{
    public class NumberToText
    {
        private Variables variables = new Variables();

        public void CreateTextFromInputNumber(string inputNumber)
        {
        }

        public void ParseInputNumber(string inputNumber)
        {
        }

        public char[] WriteInputNumberToConsole(char[] threeDigit)
        {
            var threeDigitChar = threeDigit;

            for (int i = 2; i < 3 - threeDigitChar.Length; i--)
            {
                variables.MainDigits[i] = threeDigitChar[i];
            }

            return variables.MainDigits;
        }

        public string MatchDigitsToWriteConsole(char[] threeDigitChar)
        {
            for (int i = 2; i >= (3 - threeDigitChar.Length); i--)
            {
                variables.MainDigits[i] = threeDigitChar[i - (3 - threeDigitChar.Length)];
            }

            if (variables.OneToNineDigit.ContainsKey(variables.MainDigits[0]))
            {
                variables.finalTextForConsole += variables.OneHunderedToNineHunderedDigit[variables.MainDigits[0]];
            }
            if (variables.OneToNineDigit.ContainsKey(variables.MainDigits[1]))
            {
                variables.finalTextForConsole += variables.TenToNinetyDigit[variables.MainDigits[1]];
            }
            if (variables.OneToNineDigit.ContainsKey(variables.MainDigits[2]))
            {
                variables.finalTextForConsole += variables.OneToNineDigit[variables.MainDigits[2]];
            }

            //Console.WriteLine(variables.finalTextForConsole);

            return variables.finalTextForConsole;
        }
    }
}