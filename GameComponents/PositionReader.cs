using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents
{
    class PositionReader
    {
        public static Position ChessPositionToArrayPosition(string userInput)
        {
            userInput = userInput.ToUpper();
            string line = userInput[0].ToString();
            string column = userInput[1].ToString();
            Position position = new Position(LineToX(line), ColumnToY(column));
            return position;
        }

        public static int LineToX(string l)
        {
            int line = int.Parse(l);
            return line - 1;
        }
        public static int ColumnToY(string c)
        {
            switch (c)
            {
                case "A":
                    return 0;
                case "B":
                    return 1;
                case "C":
                    return 2;
                case "D":
                    return 3;
                case "E":
                    return 4;
                case "F":
                    return 5;
                case "G":
                    return 6;
                case "H":
                    return 7;
                default:
                    throw new Exception("Invalid Column");
            }
        }
    }
}
