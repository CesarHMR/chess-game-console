using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents.ChessPieces
{
    class Rook : Piece
    {
        public Rook(Color color, Position position) : base(color, position) { }

        public override string ToString()
        {
            return "R";
        }
    }
}
