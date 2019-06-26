namespace ChessMVC
{
    public class Board
    {
        private ChessPiece[,] board = new ChessPiece[8, 8];
        public ChessPiece this[int col, int row]
        {
            get
            {
                return board[col, row];
            }
            set
            {
                board[col, row] = value;
            }
        }
    }
}