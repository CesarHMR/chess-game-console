using GameComponents.ChessPieces;

namespace GameComponents
{
    class ChessBoard
    {
        int size = 8;
        Piece[,] pieces = new Piece[8, 8];

        public void PlacePiece(Piece p)
        {
            if (ThisPositionIsEmpty(p.position))
            {
                pieces[p.position.x, p.position.y] = p;
            }
        }

        public bool ThisPositionIsEmpty(Position pos) => pieces[pos.x, pos.y] == null;
        public string GetPieceName(Position pos) => pieces[pos.x, pos.y].ToString();
    }
}
