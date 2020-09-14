using GameComponents;
using GameComponents.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard board = new ChessBoard();
            board.SetNewBoard();
            Screen.PrintBoard(board);

            Console.ReadLine();
        }
    }
}
