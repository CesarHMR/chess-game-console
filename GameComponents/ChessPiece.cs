using GameComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents
{
    abstract class ChessPiece
    {
        public Color color { get; protected set; }
        public Position position { get; protected set; }
        public Board board { get; protected set; }

        public ChessPiece(Color color, Position position, Board board)
        {
            this.color = color;
            this.position = position;
            this.board = board;
        }

    }
}
