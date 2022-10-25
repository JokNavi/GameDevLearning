namespace TestGame
{
    public class GenerateNumbers
    {
        private Random RD = new Random();
        public int[] Numbers = new int[MainProgram.AmountOfNumbers];
        public char[] Operators = new char[MainProgram.AmountOfNumbers];
        private char[] OperatorChoices = { '^', '*', '/', '+', '-' };

        public int[] GenerateNumberArray()
        {
            foreach (int Index in Numbers) { Numbers.SetValue(RD.Next(-25, 25), Index); }
            return Numbers;
        }
        public int[] GenerateOperatorArray()
        {
            foreach (int OperatorIndex in Operators)
            {
                int OperatorSelection = RD.Next(-25, 25);
                Operators.SetValue(OperatorChoices[OperatorSelection], OperatorIndex);
            }
            return Numbers;
        }


    }
}
