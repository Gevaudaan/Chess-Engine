using System;
using System.Collections.Generic;
using System.Text;

namespace ChessEngineCore.Pieces
{
    public class Pawn : Piece
    {
        //atributos de la subclase
        public bool IsFirstMove { get; private set; }

        //Metodos de la subclase:

        //Constructor:
        public Pawn(PieceColor color, string symbol) : base(color, symbol)
        {
            IsFirstMove = true;
        }

        public override bool IsValidMove(Position destination, Position currentPosition)
        {
            int moveDistanceX = destination.X - currentPosition.X; //Si se mueve siempre cero, si come, 1 o -1
            int moveDistanceY = destination.Y - currentPosition.Y; //peon blanco=1 o 2 || Peon negro=-1 o -2 dependiendo de si es su primer movimiento
            int forwardStep = Math.Sign(moveDistanceY) * moveDistanceY;
            int sideStep = Math.Sign(moveDistanceX) * moveDistanceX;

            //----INICIO DE BLOQUE DE CODIGO TEMPORAL (Más adelante se delegara a la clase BOARD)--------------------------

            if (!Funcs.OutOfBoard(destination))
            {
                return false;
            }

            //----FIN DE BLOQUE DE CODIGO TEMPORAL ------------------------------------------------------------------------

            if (sideStep == 1 && forwardStep == 1)
            {
                return true;
            }

            if (forwardStep == 1)
            {
                return true;
            }
            if (forwardStep == 2 && IsFirstMove)
            {
                return true;
            }

            return false;
        }
    }
}