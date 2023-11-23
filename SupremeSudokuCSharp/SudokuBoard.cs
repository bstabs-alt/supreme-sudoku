namespace SupremeSudokuCSharp
{
    public class SudokuBoard
    {
        private int difficulty;

        public SudokuBoard(int difficulty)
        {
            this.difficulty = difficulty;
        }

        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public void PrintBoard(int[,] board)
        {
            Console.WriteLine("Printing Board");
            Console.WriteLine("-------------");

          
        }

    }
}