using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToTextProject
{
    public class NumberToTextTurkish : INumberToText
    {
        private Variables variables = new Variables();

        public void BuildAllDigitsInNumber()
        {
            for (int i = variables.digitsOrderedByAscending.Length; i > 0; i--)
            {
                if (!(variables.digitsOrderedByAscending[i - 1] == null || variables.digitsOrderedByAscending[i - 1] == ""))
                {
                    if (variables.digitsOrderedByAscending[i - 1] == "Bir" && variables.DigitsInInputNumberTurkish[i - 1] == "Bin")
                    {
                        Console.Write(variables.DigitsInInputNumberTurkish[i - 1]);
                    }
                    else
                    {
                        Console.Write(variables.digitsOrderedByAscending[i - 1] + variables.DigitsInInputNumberTurkish[i - 1]);
                    }
                }
            }
        }

        public void ParseInputNumberThreeDigitGroup(string inputNumber)
        {
            //var inputNumberParsered = inputNumber;
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
            //var threeDigitChar = threeDigit;

            for (int i = 2; i >= (3 - threeDigit.Length); i--)
            {
                variables.MainDigits[i] = threeDigit[i - (3 - threeDigit.Length)];
            }

            return variables.MainDigits;
        }

        public string MatchDigitsToWriteConsole(char[] threeDigitChar)
        {
            variables.threeDigitTextVersion = "";

            if (variables.OneToNineDigitTurkish.ContainsKey(variables.MainDigits[0]))
            {
                variables.threeDigitTextVersion += variables.OneHunderedToNineHunderedDigitTurkish[variables.MainDigits[0]];
            }
            if (variables.OneToNineDigitTurkish.ContainsKey(variables.MainDigits[1]))
            {
                variables.threeDigitTextVersion += variables.TenToNinetyDigitTurkish[variables.MainDigits[1]];
            }
            if (variables.OneToNineDigitTurkish.ContainsKey(variables.MainDigits[2]))
            {
                variables.threeDigitTextVersion += variables.OneToNineDigitTurkish[variables.MainDigits[2]];
            }

            variables.MainDigits[0] = '0';
            variables.MainDigits[1] = '0';
            variables.MainDigits[2] = '0';

            return variables.threeDigitTextVersion;
        }
    }
}