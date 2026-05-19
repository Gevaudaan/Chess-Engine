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
        //public override bool IsValidMove(Position destination)
        {
            int moveDistanceX = destination.X - CurrentPosition.X;
            int moveDistanceY = destination.Y - CurrentPosition.Y;

            //----INICIO DE BLOQUE DE CODIGO TEMPORAL (Más adelante se delegara a la clase BOARD)--------------------------
            if (!Funcs.OutOfBoard(destination))
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
