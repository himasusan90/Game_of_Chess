namespace Chess
{
    public class Board
    {
        public int size { get; set; }
        public Piece[,] ChessBoard { get;set; }
  
        public Board(int size=8)
        {
            ChessBoard=new Piece[size,size];
            for(int i = 0; i < size; i++)
            {
                ChessBoard[i,1]=new Pawn(Color.White,i,1);
                ChessBoard[i, 6] = new Pawn(Color.Black, i, 6);
            }

        }
        public bool IsCheck()
        {
            return true;
        }

       
        public bool Move(int X,int Y,int newX,int newY)
        {
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
