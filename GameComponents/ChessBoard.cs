using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents
{
    class ChessBoard
    {
        int size = 8;
        Piece[,] pieces = new Piece[8, 8];

        public void PlacePiece(Piece p)
        {
            if (ThisPositionIsAvailable(p.position))
            {
                pieces[p.position.x, p.position.y] = p;
            }
        }

        bool ThisPositionIsAvailable(Position pos) => pieces[pos.x, pos.y] == null;
    }
}
