using GameComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents.ChessPieces
{
    abstract class Piece
    {
        public Color color { get; protected set; }
        public Position position { get; protected set; }
        public Piece(Color color, Position position)
        {
            this.color = color;
            this.position = position;
        }

        public void SetNewPosition(Position position)
        {
            this.position = position;
        }
    }
}
