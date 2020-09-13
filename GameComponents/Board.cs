using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents
{
    class Board
    {
        const int size = 8;

        public int GetSize() => size;

        public override string ToString()
        {
            return "Board with " + size + "x" + size;
        }
    }
}
