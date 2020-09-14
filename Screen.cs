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
            for (int i = 0; i <= b.GetSize(); i++)
            {
                if (i == b.GetSize())
                {
                    Console.WriteLine("  A B C D E F G H");
                }
                else
                {
                    Console.Write(i + 1);

                    for (int j = 0; j < b.GetSize(); j++)
                    {
                        Console.Write(" -");
                    }
                }

                Console.WriteLine();
            }
        }

        bool IsTheLastLine(int i) => i == 8;
    }
}
