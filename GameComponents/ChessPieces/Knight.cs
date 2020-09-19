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
        public Knight(Color color, Position position) : base(color, position) { }

        public override string ToString()
        {
            return "H";//Horse
        }

        protected override List<Position> GetValidDestinations(ChessBoard board)
        {
            throw new NotImplementedException();
        }
    }
}
