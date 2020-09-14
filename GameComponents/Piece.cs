using GameComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents
{
    abstract class Piece
    {
        public Color color { get; protected set; }
        public Position position { get; protected set; }
        public ChessBoard board { get; protected set; }

        public Piece(Color color, Position position, ChessBoard board)
        {
            this.color = color;
            this.position = position;
            this.board = board;
        }

    }
}
