namespace NumberToTextProject
{
    public interface INumberToText
    {
        void BuildAllDigitsInNumber();

        void ParseInputNumberThreeDigitGroup(string inputNumber);

        char[] SetupThreeDigit(char[] threeDigit);

        string MatchDigitsToWriteConsole(char[] threeDigitChar);
    }
}