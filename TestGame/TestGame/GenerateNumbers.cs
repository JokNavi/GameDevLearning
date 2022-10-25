namespace TestGame
{
    public class GenerateNumbers
    {
        private Random RD = new Random();
        public int[] Numbers = new int[MainProgram.AmountOfNumbers];
        public char[] Operators = new char[MainProgram.AmountOfOperators];
        private char[] OperatorChoices = { '^', '*', '/', '+', '-' };
        public int[] NumberRandmiser = new int[MainProgram.AmountOfNumbers];

        public char[] GenerateOperatorArray()
        {
            foreach (char OperatorIndex in Operators)
            {
                int OperatorSelection = RD.Next(0, 5);
                Operators.SetValue(OperatorChoices[OperatorSelection], OperatorIndex);
            }
            return Operators;
        }

        public int[] GenerateNumberArray(int MinValue, int MaxValue)
        {
            foreach (int Index in Numbers) { Numbers.SetValue(RD.Next(MinValue, MaxValue), Index); }
            return Numbers;
        }

    }
}
