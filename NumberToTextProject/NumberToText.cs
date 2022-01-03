using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToTextProject
{
    public class NumberToText
    {
        private Variables variables = new Variables();

        public void BuildAllDigitsInNumber(string finalText, int digit)
        {
            Console.WriteLine(finalText + variables.DigitsInInputNumber[digit]);
        }

        public void ParseInputNumberThreeDigitGroup(string inputNumber)
        {
            var inputNumberParsered = inputNumber;
            string parseredThreeDigit;
            int digitNumber = 0;
            string threeDigitText;

            for (int i = inputNumberParsered.Length; i > 0; i = i - 3)
            {
                if (i - 3 < 0)
                {
                    parseredThreeDigit = inputNumberParsered.Substring(0, i);
                    SetupThreeDigit(parseredThreeDigit.ToCharArray());
                    threeDigitText = MatchDigitsToWriteConsole(parseredThreeDigit.ToCharArray());
                    BuildAllDigitsInNumber(threeDigitText, digitNumber);
                    //Console.WriteLine(parseredThreeDigit);
                    break;
                }
                parseredThreeDigit = inputNumberParsered.Substring(i - 3, 3);
                SetupThreeDigit(parseredThreeDigit.ToCharArray());
                threeDigitText = MatchDigitsToWriteConsole(variables.MainDigits);
                BuildAllDigitsInNumber(threeDigitText, digitNumber);
                digitNumber++;
                //Console.WriteLine(parseredThreeDigit);
            }
            digitNumber = 0;
            //Console.WriteLine(inputNumberParsered);
        }

        public char[] SetupThreeDigit(char[] threeDigit)
        {
            var threeDigitChar = threeDigit;

            for (int i = 2; i >= (3 - threeDigitChar.Length); i--)
            {
                variables.MainDigits[i] = threeDigitChar[i - (3 - threeDigitChar.Length)];
            }

            return variables.MainDigits;
        }

        public string MatchDigitsToWriteConsole(char[] threeDigitChar)
        {
            variables.threeDigitTextVersion = "";

            if (variables.OneToNineDigit.ContainsKey(variables.MainDigits[0]))
            {
                variables.threeDigitTextVersion += variables.OneHunderedToNineHunderedDigit[variables.MainDigits[0]];
            }
            if (variables.OneToNineDigit.ContainsKey(variables.MainDigits[1]))
            {
                variables.threeDigitTextVersion += variables.TenToNinetyDigit[variables.MainDigits[1]];
            }
            if (variables.OneToNineDigit.ContainsKey(variables.MainDigits[2]))
            {
                variables.threeDigitTextVersion += variables.OneToNineDigit[variables.MainDigits[2]];
            }

            return variables.threeDigitTextVersion;
        }
    }
}