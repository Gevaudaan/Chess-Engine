using System;
using System.Collections.Generic;
using System.Text;

namespace ChessEngineCore.Pieces
{
    public class Bishop:Piece
    {
        public Bishop(PieceColor color, string symbol) : base(color, symbol)
        {

        }



        public override bool IsValidMove(Position destination, Position CurrentPosition)
        {
            int moveDistanceX = Math.Abs(destination.X - CurrentPosition.X);
            int moveDistanceY = Math.Abs(destination.Y - CurrentPosition.Y);
            if (!Funcs.OutOfBoard(destination))
            {
                return false;
            }

            if (moveDistanceX != moveDistanceY)
            {
                return false;
            }
            return true; 
        }
    }
}
