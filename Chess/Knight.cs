namespace Chess
{
    public class Knight : Piece
    {
        public Knight(Color color, int x, int y) : base(color, x, y)
        {
        }
        public override char GetSymbol()
        {
            return Color == Color.White ? 'H' : 'h'; // Upper case for White, lower case for Black
        }
        public override bool IsValidMove(int newX, int newY, Piece[,] board)
        {
            if (board[newX, newY] == null)
            {
                return (Math.Abs(newX - X) == 2 && Math.Abs(newY - Y) == 1) ||
              (Math.Abs(newX - X) == 1 && Math.Abs(newY - Y) == 2);
            }
            return false;
        }
    }
}
