namespace Chess
{
    public class Rook : Piece
    {
        public Rook(Color color, int x, int y) : base(color, x, y)
        {
        }
        public override char GetSymbol()
        {
            return Color == Color.White ? 'R' : 'r'; // Upper case for White, lower case for Black
        }
        public override bool IsValidMove(int newX, int newY, Piece[,] board)
        {
            if (board[newX, newY] == null)
            {
                if (newX == X || newY == Y)
                {
                    return true;
                }
               
            }
            return false;
        }
    }
}
