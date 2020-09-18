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
                Console.WriteLine("Place a Pawn in :");
                string userMessage = Console.ReadLine();
                Position chosenPosition = PositionConverter.ChessPositionToArrayPosition(userMessage);
                board.PlacePiece(new Pawn(Color.BLACK, chosenPosition, board));
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
