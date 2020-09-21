using Chess;
using GameComponents.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents
{
    static class GameManager
    {
        public static ChessBoard board { get; private set; }
        static Color playerToPlay;
        static King[] kings = new King[2];

        public static void StartGame()
        {
            board = new ChessBoard();
            board.SetNewGame();
            kings = AddKingsFromBoard();
            playerToPlay = Color.WHITE;
            Screen.PrintBoard(board);
        }

        static King[] AddKingsFromBoard()
        {
            King[] kingsToAdd = new King[2];
            foreach (Piece p in board.GetPieces())
            {
                if(p.ToString() == "K")
                {
                    if(p.color == Color.WHITE)
                    {
                        kingsToAdd[0] = (King)p;
                    }
                    else
                    {
                        kingsToAdd[1] = (King)p;
                    }
                }
            }

            return kingsToAdd;
        }
        public static void NextTurn() => playerToPlay = playerToPlay == Color.WHITE ? Color.BLACK : Color.WHITE;

        static bool CheckWinCondition()
        {
            foreach (Piece p in board.GetPieces())
            {
                if (p.ThisPieceCanKillTheKing())
                {

                }
            }
            return false;
        }

        static void CheckKingsCondition()
        {
            foreach (King k in kings)
            {
                //if(k.)
            }
        }
    }
}
