using Chess;
using GameComponents.ChessPieces;
using System;
using System.Security.Cryptography;

namespace GameComponents
{
    static class GameManager
    {
        #region Members
        public static ChessBoard board { get; private set; }
        static Color playerToPlay;
        static bool kingNeedToMove = false;
        static bool gameIsRunning = true;
        static King whiteKing;
        static King blackKing;
        #endregion

        public static void StartGame()
        {
            board = new ChessBoard();
            playerToPlay = Color.WHITE;
            Screen.PrintBoard(board);
            RequestPlayerInput();
        }

        static void SetKingsFromBoard()
        {
            foreach (Piece p in board.GetAllPieces())
            {
                if (p.ToString() == "K")
                {
                    if (p.color == Color.WHITE)
                    {
                        whiteKing = (King)p;
                    }
                    else
                    {
                        blackKing = (King)p;
                    }
                }
            }
        }
        static void NextTurn()
        {
            playerToPlay = playerToPlay == Color.WHITE ? Color.BLACK : Color.WHITE;
            RequestPlayerInput();
        }
        public static void FinishTurn()
        {
            CheckWinCondition();

            if (gameIsRunning)
                NextTurn();
        }
        static void CheckWinCondition()
        {
            kingNeedToMove = false;

            foreach (Piece p in board.GetAllPieces())
            {
                if (p.ThisPieceCanKillTheKing())
                {
                    kingNeedToMove = true;
                }
            }

            if (kingNeedToMove)
                CheckKingsCondition();
        }
        static void CheckKingsCondition()
        {
            King kingToCheck = playerToPlay == Color.WHITE ? blackKing : whiteKing;

            if (kingToCheck.CheckMate())
            {
                FinishMatch(playerToPlay);
            }
        }
        static void FinishMatch(Color color)
        {
            gameIsRunning = false;
            Console.Clear();
            Console.WriteLine("The " + color + " player has won");
        }
        static void RequestPlayerInput()
        {
            Position origin;
            Position destination;

            while (true)//destination validation
            {
                while (true)//origin validation
                {
                    Console.Clear();
                    Screen.PrintBoard(board);
                    Console.WriteLine();
                    Console.WriteLine(playerToPlay + " PLAYER TURN");
                    Console.WriteLine();
                    Console.WriteLine("Select a Piece :");
                    string originMessage = Console.ReadLine();
                    Console.WriteLine("Select a Destination :");
                    string destinationMessage = Console.ReadLine();

                    origin = PositionConverter.ChessPositionToMatrizPosition(originMessage);
                    destination = PositionConverter.ChessPositionToMatrizPosition(destinationMessage);

                    if (board.GetPiece(origin) == null || board.GetPiece(origin).color != playerToPlay)
                    {
                        Console.WriteLine("Invalid Origin Position, need select a valid piece");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }

                if (board.isValidMovement(origin, destination))
                {
                    board.MovePiece(origin, destination);
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Destination");
                    Console.ReadLine();
                }
            }

            FinishTurn();
        }
    }
}
