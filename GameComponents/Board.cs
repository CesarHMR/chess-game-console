using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents
{
    class Board
    {
        //Chess always have a 8x8 board
        const int size = 8;
        int[,] grid;

        public Board()
        {
            grid = new int[size, size];
        }
    }
}
