using System;
using System.Collections.Generic;
using System.Text;

namespace ChessEngineCore
{
    public static class Funcs
    {
        public static bool OutOfBoard(Position destination)
        {
            if (destination.X < 0 || destination.X > 7)//Revisamos que la coordenada X no se salga del tablero
            {
                return false;
            }

            if (destination.Y < 0 || destination.Y > 7) //Revisamos que la coordenada Y no se salga del tablero
            {
                return false;
            }
            return true;
        }

        public static int TwoDTo1d(Position pos)
        {
            int index = (pos.Y * 16 + pos.X % 16);
            return index;
        }

        public static Position NormalizeIndex(string input) //Takes a board coordinate like a2 o h8 and returns the 2d array coordinate.
        {
            int column = input[0]; //Turns the first char of the string into it's ascii equivalent.
            string numerigo = input[1].ToString();
            int row = int.Parse(numerigo); // contains the second char of the coordinate, the row number
            column = column - 97;//97 is the ascci of a. So Column will save what's left from the substraction 97 - 97(a) = 0, 98 - 97(b) = 1 ... 104 - 97(h) = 7
            Position pos = new Position(column, row - 1);

            return pos;
        }
    }
}