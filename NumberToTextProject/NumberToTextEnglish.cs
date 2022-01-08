using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToTextProject
{
    public class NumberToTextEnglish : INumberToText
    {
        private Variables variables = new Variables();

        public void BuildAllDigitsInNumber()
        {
            for (int i = variables.digitsOrderedByAscending.Length; i > 0; i--)
            {
                if (!(variables.digitsOrderedByAscending[i - 1] == null || variables.digitsOrderedByAscending[i - 1] == ""))
                {
                    Console.Write(variables.digitsOrderedByAscending[i - 1] + variables.DigitsInInputNumberEnglish[i - 1]);
                }
            }
        }

        public void ParseInputNumberThreeDigitGroup(string inputNumber)
        {
            string parseredThreeDigit;

            int digitNumber = 0;
            string threeDigitText;

            for (int i = inputNumber.Length; i > 0; i = i - 3)
            {
                if (i - 3 < 0)
                {
                    parseredThreeDigit = inputNumber.Substring(0, i);
                    SetupThreeDigit(parseredThreeDigit.ToCharArray());
                    threeDigitText = MatchDigitsToWriteConsole(parseredThreeDigit.ToCharArray());

                    variables.digitsOrderedByAscending[digitNumber] = threeDigitText;

                    break;
                }
                parseredThreeDigit = inputNumber.Substring(i - 3, 3);
                SetupThreeDigit(parseredThreeDigit.ToCharArray());
                threeDigitText = MatchDigitsToWriteConsole(variables.MainDigits);

                variables.digitsOrderedByAscending[digitNumber] = threeDigitText;

                digitNumber++;
            }

            digitNumber = 0;
        }

        public char[] SetupThreeDigit(char[] threeDigit)
        {
            for (int i = 2; i >= (3 - threeDigit.Length); i--)
            {
                variables.MainDigits[i] = threeDigit[i - (3 - threeDigit.Length)];
            }

            return variables.MainDigits;
        }

        public string MatchDigitsToWriteConsole(char[] threeDigitChar)
        {
            variables.threeDigitTextVersion = "";

            if (variables.OneToNineDigitEnglish.ContainsKey(variables.MainDigits[0]))
            {
                variables.threeDigitTextVersion += variables.OneHunderedToNineHunderedDigitEnglish[variables.MainDigits[0]];
            }
            if (variables.OneToNineDigitEnglish.ContainsKey(variables.MainDigits[1]))
            {
                variables.threeDigitTextVersion += variables.TenToNinetyDigitEnglish[variables.MainDigits[1]];
            }
            if (variables.MainDigits[1] == '1')
            {
                variables.threeDigitTextVersion += variables.TeensEnglish[variables.MainDigits[2]];
            }
            if (variables.OneToNineDigitEnglish.ContainsKey(variables.MainDigits[2]) && variables.MainDigits[1] != '1')
            {
                variables.threeDigitTextVersion += variables.OneToNineDigitEnglish[variables.MainDigits[2]];
            }

            variables.MainDigits[0] = '0';
            variables.MainDigits[1] = '0';
            variables.MainDigits[2] = '0';

            return variables.threeDigitTextVersion;
        }
    }
}