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
            King king = new King(Color.BLACK, new Position(0,4), board);
            board.PlacePiece(king);
            Screen.PrintBoard(board);

            Console.ReadLine();
        }
    }
}
