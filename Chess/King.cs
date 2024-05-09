namespace Chess
{
    public class King : Piece
    {
        public King(Color color, int x, int y) : base(color, x, y)
        {
        }
        public override char GetSymbol()
        {
            return Color == Color.White ? 'K' : 'k'; // Upper case for White, lower case for Black
        }
        public override bool IsValidMove(int newX, int newY, Piece[,] board)
        {
            if (board[newX, newY] == null)
            {
               
                    if(Math.Abs(newX-X)<=1 &&  Math.Abs(newY - Y)<=1)
                    return true;              
            }
            return false;
        }
    }
}
