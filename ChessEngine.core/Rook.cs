using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ChessEngineCore
{
    public class Rook:Piece
    {
        public Rook(PieceColor color) : base(color)
        {

        }

        //public override bool IsValidMove(Position destination)
        public override bool IsValidMove(Position destination, Position CurrentPosition)
        {
            int moveDistanceX = destination.X - CurrentPosition.X;
            int moveDistanceY = destination.Y - CurrentPosition.Y;

            if (!FuncionesUtiles.OutOfBoard(destination))
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
