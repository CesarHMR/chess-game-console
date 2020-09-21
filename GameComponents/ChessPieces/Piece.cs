using GameComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents.ChessPieces
{
    abstract class Piece
    {
        #region Settings
        public Color color { get; protected set; }
        public Position position { get; protected set; }
        public Piece(Color color, Position position)
        {
            this.color = color;
            this.position = position;
        }

        protected ChessBoard board = GameManager.board;
        #endregion

        public void SetNewPosition(Position position)
        {
            this.position = position;
        }
        public bool ThisPieceCanKillTheKing()
        {
            foreach (Position pos in GetValidDestinations())
            {
                Piece pieceInThisPosition = GameManager.board.GetPiece(pos);

                if (pieceInThisPosition != null)
                {
                    if (IsAnEnemyKing(pieceInThisPosition))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        bool IsAnEnemyKing(Piece p) => p.ToString() == "K" && p.color != this.color;
        public bool IsValidMovement(Position destination)
        {
            List<Position> validDestinations = GetValidDestinations();

            foreach (Position validDestination in validDestinations)
            {
                if (destination.isEqual(validDestination))
                {
                    return true;
                }
            }

            return false;
        }
        protected abstract List<Position> GetValidDestinations();
        public bool CanMove() => GetValidDestinations().Count > 0;
    }
}
