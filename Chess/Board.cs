namespace Chess
{
    public class Board
    {
        public int size { get; set; }
        public Piece[,] ChessBoard { get;set; }
  
        public Board(int size=8)
        {
            ChessBoard=new Piece[size,size];
            ChessBoard[0,0] = new Rook(Color.White, 0,0);
            ChessBoard[7,0] = new Rook(Color.White,7,0);
            ChessBoard[0, 7] = new Rook(Color.Black, 0, 7);
            ChessBoard[7, 7] = new Rook(Color.Black, 7, 7);

            ChessBoard[4,0] = new King(Color.White, 4, 0);
            ChessBoard[4, 7] = new King(Color.Black, 4, 7);
            // Place bishops
            ChessBoard[2, 0] = new Bishop(Color.White, 2, 0);
            ChessBoard[5, 0] = new Bishop(Color.White, 5, 0);
            ChessBoard[2, 7] = new Bishop(Color.Black, 2, 7);
            ChessBoard[5, 7] = new Bishop(Color.Black, 5, 7);

            // Place knights
            ChessBoard[1, 0] = new Knight(Color.White, 1, 0);
            ChessBoard[6, 0] = new Knight(Color.White, 6, 0);
            ChessBoard[1, 7] = new Knight(Color.Black, 1, 7);
            ChessBoard[6, 7] = new Knight(Color.Black, 6, 7);

            ChessBoard[3, 0] = new Queen(Color.White, 3, 0);  // White queen at d1 in standard notation
            ChessBoard[3, 7] = new Queen(Color.Black, 3, 7);
            for (int i = 0; i < size; i++)
            {
                ChessBoard[i,1]=new Pawn(Color.White,i,1);
                ChessBoard[i, 6] = new Pawn(Color.Black, i, 6);
            }

        }
        public bool IsCheck()
        {
            return false;
        }
        public static bool IsWithinBounds(int x, int y)
        {
            return x >= 0 && x < 8 && y >= 0 && y < 8;
        }

        public bool Move(int X,int Y,int newX,int newY)
        {
            if (!IsWithinBounds(newX, newY)) return false;
            Piece piece = ChessBoard[X,Y];
            if (piece != null && piece.IsValidMove(newX,newY, ChessBoard))
            {
                piece.X=newX; piece.Y=newY;
                ChessBoard[newX,newY] = piece;
                ChessBoard[X, Y] = null;
                return true;

            }
            return false;
        }
    }
}
