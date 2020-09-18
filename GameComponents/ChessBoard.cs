using Chess.GameComponents.ChessPieces;
using GameComponents.ChessPieces;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace GameComponents
{
    class ChessBoard
    {
        Piece[,] pieces = new Piece[8, 8];
        List<Piece> deadPieces = new List<Piece>();

        public void MovePiece(Position origin, Position destination)
        {
            if (GetPiece(origin) == null)
                return;

            if (IsInsideTheBoardRange(destination))
            {
                Piece pieceToMove = GetPiece(origin);
                RemovePiece(pieceToMove);
                pieceToMove.SetNewPosition(destination);
                PlacePiece(pieceToMove);
            }
        }

        void PlacePiece(Piece p)
        {
            if (IsInsideTheBoardRange(p.position))
            {
                Piece deadPiece = GetPiece(p.position);

                if (deadPiece != null)
                    deadPieces.Add(deadPiece);

                pieces[p.position.x, p.position.y] = p;
            }
        }

        void RemovePiece(Piece p)
        {
            pieces[p.position.x, p.position.y] = null;
        }
        public Piece GetPiece(Position pos) => pieces[pos.x, pos.y];
        public void SetNewBoard()
        {
            List<Piece> piecesToPlace = new List<Piece>();

            for (int i = 0; i < 8; i++)
            {
                Pawn whitePawn = new Pawn(Color.WHITE, new Position(1, i));
                Pawn blackPawn = new Pawn(Color.BLACK, new Position(6, i));
                piecesToPlace.Add(whitePawn);
                piecesToPlace.Add(blackPawn);
            }

            Rook whiteRookL = new Rook(Color.WHITE, new Position(0, 0));
            Rook whiteRookR = new Rook(Color.WHITE, new Position(0, 7));
            Rook blackRookL = new Rook(Color.BLACK, new Position(7, 0));
            Rook blackRookR = new Rook(Color.BLACK, new Position(7, 7));

            piecesToPlace.Add(whiteRookL);
            piecesToPlace.Add(whiteRookR);
            piecesToPlace.Add(blackRookL);
            piecesToPlace.Add(blackRookR);

            Knight whiteKnightL = new Knight(Color.WHITE, new Position(0, 1));
            Knight whiteKnightR = new Knight(Color.WHITE, new Position(0, 6));
            Knight blackKnightL = new Knight(Color.BLACK, new Position(7, 1));
            Knight blackKnightR = new Knight(Color.BLACK, new Position(7, 6));

            piecesToPlace.Add(whiteKnightL);
            piecesToPlace.Add(whiteKnightR);
            piecesToPlace.Add(blackKnightL);
            piecesToPlace.Add(blackKnightR);

            Bishop whiteBishopL = new Bishop(Color.WHITE, new Position(0, 2));
            Bishop whiteBishopR = new Bishop(Color.WHITE, new Position(0, 5));
            Bishop blackBishopL = new Bishop(Color.BLACK, new Position(7, 2));
            Bishop blackBishopR = new Bishop(Color.BLACK, new Position(7, 5));

            piecesToPlace.Add(whiteBishopL);
            piecesToPlace.Add(whiteBishopR);
            piecesToPlace.Add(blackBishopL);
            piecesToPlace.Add(blackBishopR);

            King whiteKing = new King(Color.WHITE, new Position(0, 3));
            King blackKing = new King(Color.BLACK, new Position(7, 3));
            Queen whiteQueen = new Queen(Color.WHITE, new Position(0, 4));
            Queen blackQueen = new Queen(Color.BLACK, new Position(7, 4));

            piecesToPlace.Add(whiteKing);
            piecesToPlace.Add(blackKing);
            piecesToPlace.Add(whiteQueen);
            piecesToPlace.Add(blackQueen);

            foreach (var p in piecesToPlace)
            {
                PlacePiece(p);
            }
        }
        bool IsInsideTheBoardRange(Position pos) => (pos.x < 8 && pos.x >= 0) && (pos.y < 8 && pos.y >= 0);
    }
}
