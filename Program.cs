using GameComponents;
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
            ChessBoard b = new ChessBoard();
            Screen.PrintBoard(b);


            Console.ReadLine();
        }
    }
}
