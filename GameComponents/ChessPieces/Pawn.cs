using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents.ChessPieces
{
    class Pawn : Piece
    {
        public Pawn(Color color, Position position) : base(color, position) { }

        public override string ToString()
        {
            return "P";
        }

        protected override List<Position> GetValidDestinations()
        {
            List<Position> validPositions = new List<Position>();

            int Updirection = color == Color.WHITE ? 1 : -1;

            Position front = new Position(position.x + Updirection, position.y);
            Position doubleFront = new Position(position.x + Updirection * 2, position.y);
            Position leftDiagonal = new Position(position.x + Updirection, position.y - 1);
            Position rightDiagonal = new Position(position.x + Updirection, position.y + 1);


            if (board.GetPiece(front) == null)
            {
                validPositions.Add(front);

                if (board.GetPiece(doubleFront) == null)
                {
                    validPositions.Add(doubleFront);
                }
            }

            if (board.GetPiece(leftDiagonal) != null)
            {
                if (board.GetPiece(leftDiagonal).color != this.color)
                    validPositions.Add(leftDiagonal);
            }

            if (board.GetPiece(rightDiagonal) != null)
            {
                if (board.GetPiece(rightDiagonal).color != this.color)
                    validPositions.Add(rightDiagonal);
            }

            return validPositions;
        }
    }
}
