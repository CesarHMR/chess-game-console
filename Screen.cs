using GameComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Screen
    {
        public static void PrintBoard(ChessBoard b)
        {
            for (int i = 7; i >= 0; i--)//for each column
            {
                Console.Write(i + 1);

                for (int j = 0; j < 8; j++)//for each line
                {
                    Position thisPosition = new Position(i, j);

                    if (b.ThisPositionIsEmpty(thisPosition))
                    {
                        Console.Write(" -");
                    }
                    else
                    {
                        Console.Write(" " + b.GetPieceName(thisPosition));
                    }
                }

                Console.WriteLine();

                if (IsTheLastLine(i))
                {
                    Console.WriteLine("  A B C D E F G H");
                }
            }
        }

        static bool IsTheLastLine(int i) => i == 0;
    }
}
