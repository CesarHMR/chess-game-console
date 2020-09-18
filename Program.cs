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
            try
            {
                //Create ChessBoard
                ChessBoard board = new ChessBoard();
                board.SetNewBoard();
                Screen.PrintBoard(board);
                //Place a Piece
                Console.WriteLine();

                Console.WriteLine("Select a Piece :");
                string originMessage = Console.ReadLine();
                Console.WriteLine("Select a Destination :");
                string destinationMessage = Console.ReadLine();

                Position originPosition = PositionConverter.ChessPositionToArrayPosition(originMessage);
                Position destinationPosition = PositionConverter.ChessPositionToArrayPosition(destinationMessage);
                board.MovePiece(originPosition, destinationPosition);

                Console.Clear();
                Screen.PrintBoard(board);
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
