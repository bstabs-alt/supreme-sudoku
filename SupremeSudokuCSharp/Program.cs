namespace SupremeSudokuCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int difficulty = Setup();
            SudokuBoard board = new SudokuBoard(difficulty);

            int[,] sudokuBoard = new int[9, 9]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            board.PrintBoard(sudokuBoard);
        }



        private static int Setup()
        {
            Console.WriteLine("Supreme Sudoku!");
            Console.WriteLine("1. Easy\n" + "2.Medium\n" + "3.Hard\n");
            int difficulty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Creating Sudoku Board: ");
            switch (difficulty)
            {
                case 1:
                    Console.WriteLine("Easy");
                    return difficulty;            
                case 2:
                    Console.WriteLine("Medium");
                    return difficulty;
                case 3:
                    Console.WriteLine("Hard");
                    return difficulty; 
                default:
                    Console.WriteLine("Invalid");
                    return 0;
            }
        }
    }
}
