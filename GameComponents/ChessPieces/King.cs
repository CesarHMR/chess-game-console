using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents.ChessPieces
{
    class King : Piece
    {
        public King(Color color, Position position) : base(color, position) { }

        public override string ToString()
        {
            return "K";
        }
        protected override List<Position> GetValidDestinations(ChessBoard board)
        {
            return new List<Position>();
        }

        public bool CheckMate()
        {
            /*            if(GetValidDestinations() != null)
                        {
                            foreach (Position p in GetValidDestinations())
                            {
                                if(p)
                            }
                        }*/
            return false;
        }
    }
}
