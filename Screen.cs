using GameComponents;
using GameComponents.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Screen
    {
        public static void PrintBoard(ChessBoard board)
        {
            for (int i = 7; i >= 0; i--)//for each column
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(i + 1);
                Console.ForegroundColor = ConsoleColor.White;

                for (int j = 0; j < 8; j++)//for each line
                {
                    Position thisPosition = new Position(i, j);
                    Piece thisPiece = board.GetPiece(thisPosition);

                    if (thisPiece == null)
                    {
                        Console.Write(" -");
                    }
                    else
                    {
                        PrintPieceWithColor(thisPiece);
                    }
                }

                Console.WriteLine();

                if (IsTheLastLine(i))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("  A B C D E F G H");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        static bool IsTheLastLine(int i) => i == 0;

        static void PrintPieceWithColor(Piece p)
        {
            if (p.color == Color.BLACK)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.Write(" " + p.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
