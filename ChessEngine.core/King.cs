using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ChessEngineCore
{
    internal class King : Piece
    {
        public bool HasMoved;
        public King(PieceColor color) : base(color){
            
        }
        public override bool IsValidMove(Position destination)
        {
            int moveDistanceX = destination.X - CurrentPosition.X;
            int moveDistanceY = destination.Y - CurrentPosition.Y;

            if (!FuncionesUtiles.OutOfBoard(destination))
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
