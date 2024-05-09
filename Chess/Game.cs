namespace Chess
{
    public class Game
    {
        //Always remember properties are bottomup
        //methods are top down
        public Board Board { get; set; }
        public Player CurrentPlayer { get; set; }
        public Player Opponent { get; set; }
        public Game(Player player1, Player player2,int size=8)
        {
            Board = new Board(size); 
            CurrentPlayer = player1;
            Opponent = player2;
        }
        public void NextPlayer()
        {
            var temp= CurrentPlayer;
            CurrentPlayer=Opponent;
            Opponent = CurrentPlayer;
        }

        public bool MakeMove(int X,int Y,int newX,int newY)
        {
            if (Board.Move(X, Y, newX, newY)){
                NextPlayer();
                return true;
            }
            return false;
        }
        public bool IsGameOver()
        {
            // Implementation of game over condition (checkmate, stalemate, etc.)
            return false;
        }
        public void PrintBoard()
        {
            Console.WriteLine("  A B C D E F G H");
            for (int y = 0; y < 8; y++)
            {
                Console.Write($"{y + 1} ");
                for (int x = 0; x < 8; x++)
                {
                    var piece = Board.ChessBoard[x, y];
                    char symbol = piece == null ? '.' : piece.GetSymbol();
                    Console.Write($"{symbol} ");
                }
                Console.WriteLine();
            }
        }
    }
}
