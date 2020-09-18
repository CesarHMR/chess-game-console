using Chess.GameComponents.ChessPieces;
using GameComponents.ChessPieces;
using System.Collections.Generic;

namespace GameComponents
{
    class ChessBoard
    {
        Piece[,] pieces = new Piece[8, 8];

        public void PlacePiece(Piece p)
        {
            if(IsValidPosition(p))
            {
                pieces[p.position.x, p.position.y] = p;
            }
        }

        bool IsValidPosition(Piece p) 
        {
            if(IsOutsideTheBoardRange(p.position))
            {
                string message =
                    "Invalid Position -- Piece is being placed outside the board range (8x8)\n" +
                    "Piece type: " + p.ToString() + " -- Piece position: " + p.position.ToString();

                throw new BoardException(message);
            }
            else
            {
                return true;
            }
        }
        public string GetPieceName(Position pos) => pieces[pos.x, pos.y].ToString();
        public void SetNewBoard()
        {
            List<Piece> piecesToPlace = new List<Piece>();

            for (int i = 0; i < 8; i++)
            {
                Pawn whitePawn = new Pawn(Color.WHITE, new Position(1, i), this);
                Pawn blackPawn = new Pawn(Color.BLACK, new Position(6, i), this);
                piecesToPlace.Add(whitePawn);
                piecesToPlace.Add(blackPawn);
            }

            Rook whiteRookL = new Rook(Color.WHITE, new Position(0, 0), this);
            Rook whiteRookR = new Rook(Color.WHITE, new Position(0, 7), this);
            Rook blackRookL = new Rook(Color.BLACK, new Position(7, 0), this);
            Rook blackRookR = new Rook(Color.BLACK, new Position(7, 7), this);

            piecesToPlace.Add(whiteRookL);
            piecesToPlace.Add(whiteRookR);
            piecesToPlace.Add(blackRookL);
            piecesToPlace.Add(blackRookR);

            Knight whiteKnightL = new Knight(Color.WHITE, new Position(0, 1), this);
            Knight whiteKnightR = new Knight(Color.WHITE, new Position(0, 6), this);
            Knight blackKnightL = new Knight(Color.BLACK, new Position(7, 1), this);
            Knight blackKnightR = new Knight(Color.BLACK, new Position(7, 6), this);

            piecesToPlace.Add(whiteKnightL);
            piecesToPlace.Add(whiteKnightR);
            piecesToPlace.Add(blackKnightL);
            piecesToPlace.Add(blackKnightR);

            Bishop whiteBishopL = new Bishop(Color.WHITE, new Position(0, 2), this);
            Bishop whiteBishopR = new Bishop(Color.WHITE, new Position(0, 5), this);
            Bishop blackBishopL = new Bishop(Color.BLACK, new Position(7, 2), this);
            Bishop blackBishopR = new Bishop(Color.BLACK, new Position(7, 5), this);

            piecesToPlace.Add(whiteBishopL);
            piecesToPlace.Add(whiteBishopR);
            piecesToPlace.Add(blackBishopL);
            piecesToPlace.Add(blackBishopR);

            King whiteKing = new King(Color.WHITE, new Position(0, 3), this);
            King blackKing = new King(Color.BLACK, new Position(7, 3), this);
            Queen whiteQueen = new Queen(Color.WHITE, new Position(0, 4), this);
            Queen blackQueen = new Queen(Color.BLACK, new Position(7, 4), this);

            piecesToPlace.Add(whiteKing);
            piecesToPlace.Add(blackKing);
            piecesToPlace.Add(whiteQueen);
            piecesToPlace.Add(blackQueen);

            foreach (var item in piecesToPlace)
            {
                PlacePiece(item);
            }
        }
        public bool IsThisPositionIsEmpty(Position pos) => pieces[pos.x, pos.y] == null;
        bool IsOutsideTheBoardRange(Position pos) => pos.x >= 8 || pos.y >= 8;
    }
}
