namespace Chess
{
    public enum Color
    {
        Black,White
    }
    public abstract class Piece
    {
        //every class
        public  int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; }

        protected Piece(Color color, int x, int y)
        {
            Color = color;
            X = x;
            Y = y;
        }

        public abstract bool IsValidMove(int newX, int newY, Piece[,] chessBoard);

        public abstract char GetSymbol();
        
    }
}
