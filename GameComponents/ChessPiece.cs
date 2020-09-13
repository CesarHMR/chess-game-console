using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents
{
    public abstract class ChessPiece
    {
        public Color color { get; protected set; }
        //public Position pos;

        public abstract void a();
    }
}
