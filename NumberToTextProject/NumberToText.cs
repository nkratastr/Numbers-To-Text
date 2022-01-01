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

        public char[] WriteInputNumberToConsole(string threeDigit)
        {
            var threeDigitChar = threeDigit.ToCharArray();

            for (int i = 0; i < 3; i++)
            {
                variables.MainDigits[i] = threeDigitChar[i];
            }

            return variables.MainDigits;
        }

        public string MatchDigitsToWriteConsole(char[] threeDigitChar)
        {
            if (variables.OneToNineDigit.ContainsKey(threeDigitChar[2]) || char.IsDigit(threeDigitChar[2]))
            {
                variables.finalTextForConsole += variables.OneHunderedToNineHunderedDigit[threeDigitChar[0]];
            }
            if (variables.OneToNineDigit.ContainsKey(threeDigitChar[1]))
            {
                variables.finalTextForConsole += variables.TenToNinetyDigit[threeDigitChar[1]];
            }
            if (variables.OneToNineDigit.ContainsKey(threeDigitChar[0]))
            {
                variables.finalTextForConsole += variables.OneToNineDigit[threeDigitChar[2]];
            }

            //Console.WriteLine(variables.finalTextForConsole);

            return variables.finalTextForConsole;
        }
    }
}