using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ChessEngineCore.Pieces
{
    public class Rook:Piece
    {
        public Rook(PieceColor color, char symbol) : base(color, symbol)
        {

        }

        //public override bool IsValidMove(Position destination)
        public override bool IsValidMove(Position destination, Position CurrentPosition)
        {
            int moveDistanceX = destination.X - CurrentPosition.X;
            int moveDistanceY = destination.Y - CurrentPosition.Y;

            if (!Funcs.OutOfBoard(destination))
            {
                return false;
            }

            if(moveDistanceX != 0 && moveDistanceY != 0)
            {
                return false;
            }

            return true;
        }
    }
}
