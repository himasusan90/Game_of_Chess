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
    public class Queen : Piece
    {
        public Queen(Color color, int x, int y) : base(color, x, y) { }

        public override bool IsValidMove(int newX, int newY, Piece[,] board)
        {
            if (!Board.IsWithinBounds(newX, newY)) return false;

            // Check for valid queen move (combination of rook and bishop moves)
            if ((X == newX || Y == newY) || (Math.Abs(newX - X) == Math.Abs(newY - Y)))
            {
                // Check if the path to the destination is clear
                int deltaX = newX != X ? (newX > X ? 1 : -1) : 0;
                int deltaY = newY != Y ? (newY > Y ? 1 : -1) : 0;
                int checkX = X + deltaX;
                int checkY = Y + deltaY;

                while (checkX != newX || checkY != newY)
                {
                    if (board[checkX, checkY] != null) return false;
                    checkX += deltaX;
                    checkY += deltaY;
                }
                return true;
            }
            return false;
        }

        public override char GetSymbol()
        {
            return Color == Color.White ? 'Q' : 'q';
        }
    }

}
