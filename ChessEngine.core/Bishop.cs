using System;
using System.Collections.Generic;
using System.Text;

namespace ChessEngineCore
{
    public class Bishop:Piece
    {
        public Bishop(PieceColor color) : base(color)
        {

        }



        //public override bool IsValidMove(Position destination, Position CurrentPosition)
        public override bool IsValidMove(Position destination)
        {
            int moveDistanceX = destination.X - CurrentPosition.X;
            int moveDistanceY = destination.Y - CurrentPosition.Y;

            //----INICIO DE BLOQUE DE CODIGO TEMPORAL (Más adelante se delegara a la clase BOARD)--------------------------
            if (destination.X < 0 || destination.X > 7)//Revisamos que la coordenada X no se salga del tablero
            {
                return false;
            }

            if (destination.Y < 0 || destination.Y > 7) //Revisamos que la coordenada Y no se salga del tablero
            {
                return false;
            }
            
            //----FIN DE BLOQUE DE CODIGO TEMPORAL ------------------------------------------------------------------------

            if (moveDistanceX != moveDistanceY)
            {
                return false;
            }
            return true; 
        }
    }
}
