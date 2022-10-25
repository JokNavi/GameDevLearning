namespace TestGame
{
    public class GenerateNumbers
    {
        private Random RD = new Random();
        public int[] Numbers = new int[MainProgram.AmountOfNumbers];

        public int[] GenerateArray() 
        {
            foreach (int Index in Numbers){Numbers.SetValue(RD.Next(-25, 25), Index);}
            return Numbers;
        }

    }
}
