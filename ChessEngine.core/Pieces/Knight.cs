using System;
using System.Collections.Generic;
using System.Text;

namespace ChessEngineCore.Pieces
{
    public class Knight:Piece
    {
        public Knight(PieceColor color, char symbol) : base(color, symbol)
        { 
        
        }

        public override bool IsValidMove(Position destination, Position CurrentPosition)
        {
            int moveDistanceX = destination.X - CurrentPosition.X;
            int moveDistanceY = destination.Y - CurrentPosition.Y;

            //----INICIO DE BLOQUE DE CODIGO TEMPORAL (Más adelante se delegara a la clase BOARD)--------------------------
            if (!Funcs.OutOfBoard(destination))
            {
                return false;
            }
            //FIN DE BLOQUE TEMPORAL
            if(moveDistanceX>2 || moveDistanceX < -2)
            {
                return false;
            }

            if (moveDistanceY > 4 || moveDistanceX < -4)
            {
                return false;
            }
            if(moveDistanceX==0 || moveDistanceY == 0)
            {
                return false;
            }

            return true;
        }
    }
}
