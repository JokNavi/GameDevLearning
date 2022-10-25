namespace TestGame
{
    class MainProgram
    {
        public static int AmountOfNumbers = 4;
        public static int AmountOfOperators = AmountOfNumbers - 1;
        static void Main(string[] args)
        {
            GenerateNumbers generateNumbers = new GenerateNumbers();
            Console.WriteLine( generateNumbers.GenerateNumberArray());
        }
    }
}