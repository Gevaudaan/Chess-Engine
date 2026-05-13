using System;
using System.Collections.Generic;
using System.Text;

namespace ChessEngineCore
{
    public class Queen:Piece
    {

        public Queen(PieceColor color) : base(color)
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

            if (moveDistanceX == moveDistanceY)
            {
                return true;
            }
            if (moveDistanceX != 0 && moveDistanceY != 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

    }
}
