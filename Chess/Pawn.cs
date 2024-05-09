namespace Chess
{
    public class Pawn : Piece
    {
        public Pawn(Color color, int x, int y) : base(color, x, y)
        {
        }
        public override char GetSymbol()
        {
            return Color == Color.White ? 'P' : 'p'; // Upper case for White, lower case for Black
        }
        public override bool IsValidMove(int newX, int newY, Piece[,]board)
        {
            if (board[newX, newY] == null)
            {
                if (newX == X && newY == Y + 1 && Color == Color.White)
                {
                    return true;
                }
                if (newX == X && newY == Y - 1 && Color == Color.Black)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
