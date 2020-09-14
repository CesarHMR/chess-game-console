using GameComponents;
using GameComponents.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.GameComponents.ChessPieces
{
    class Knight : Piece
    {
        public Knight(Color color, Position position, ChessBoard board) : base(color, position, board) { }

        public override string ToString()
        {
            return "H";//Horse
        }
    }
}
