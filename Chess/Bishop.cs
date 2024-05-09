namespace Chess
{
    public class Bishop : Piece
    {
        public Bishop(Color color, int x, int y) : base(color, x, y)
        {
        }
        public override char GetSymbol()
        {
            return Color == Color.White ? 'B' : 'b'; // Upper case for White, lower case for Black
        }
        public override bool IsValidMove(int newX, int newY, Piece[,] board)
        {
            if (!Board.IsWithinBounds(newX, newY)) return false;
            // Check for diagonal movement
            if (Math.Abs(newX - X) != Math.Abs(newY - Y)) return false;

            // Check for unobstructed path
            int deltaX = newX > X ? 1 : -1;
            int deltaY = newY > Y ? 1 : -1;
            int checkX = X + deltaX, checkY = Y + deltaY;
            while (checkX != newX)
            {
                if (board[checkX, checkY] != null) return false;
                checkX += deltaX;
                checkY += deltaY;
            }
            return true;
        }
    }
}
