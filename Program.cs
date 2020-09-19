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
                ChessBoard board = new ChessBoard();
                board.SetNewGame();
                Screen.PrintBoard(board);
                for (int i = 0; i < 5; i++)
                {

                    Console.WriteLine("Select a Piece :");
                    string originMessage = Console.ReadLine();
                    Console.WriteLine("Select a Destination :");
                    string destinationMessage = Console.ReadLine();

                    Position originPosition = PositionConverter.ChessPositionToArrayPosition(originMessage);
                    Position destinationPosition = PositionConverter.ChessPositionToArrayPosition(destinationMessage);

                    if (board.isValidMovement(originPosition, destinationPosition))
                    {
                        board.MovePiece(originPosition, destinationPosition);
                        Console.Clear();
                        Screen.PrintBoard(board);
                    }
                    else
                    {
                        Console.WriteLine("End Game");
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
