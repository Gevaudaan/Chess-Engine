using System;
using System.Collections.Generic;
using System.Text;

namespace ChessEngineCore
{
    public class Knight:Piece
    {
        public Knight(PieceColor color):base(color) { 
        
        }

        public override bool IsValidMove(Position destination, Position CurrentPosition)
        {
            int moveDistanceX = destination.X - CurrentPosition.X;
            int moveDistanceY = destination.Y - CurrentPosition.Y;

            //----INICIO DE BLOQUE DE CODIGO TEMPORAL (Más adelante se delegara a la clase BOARD)--------------------------
            if (!FuncionesUtiles.OutOfBoard(destination))
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

            return true;
        }
    }
}
