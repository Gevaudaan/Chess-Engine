using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ChessEngineCore.Pieces
{
    public class King : Piece
    {
        public bool HasMoved;
        public King(PieceColor color) : base(color){
            
        }
        public override bool IsValidMove(Position destination, Position CurrentPosition)
        //public override bool IsValidMove(Position destination)
        {
            int moveDistanceX = destination.X - CurrentPosition.X;
            int moveDistanceY = destination.Y - CurrentPosition.Y;

            if (!Funcs.OutOfBoard(destination))
            {
                return false;
            }
            if (HasMoved)
            {
                if(moveDistanceX>2 || moveDistanceX < -2)
                {
                    return false;
                }
            }
            else
            {
                if (moveDistanceX > 1 || moveDistanceY > 1)
                {
                    return false;
                }
                if (moveDistanceY < -1 || moveDistanceY < -1)
                {
                    return false;
                }
            }
                return true;

        }

    }
}
