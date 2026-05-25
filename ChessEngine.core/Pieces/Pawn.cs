using System;
using System.Collections.Generic;
using System.Text;

namespace ChessEngineCore.Pieces
{
    public class Pawn : Piece
    {
        //atributos de la subclase
        public bool isFirstMove { get; private set; }

        //Metodos de la subclase:

        //Constructor:
        public Pawn(PieceColor color, string symbol) : base(color, symbol)
        {
            isFirstMove = true;
        }

        public override bool IsValidMove(Position destination, Position CurrentPosition)
        //public override bool IsValidMove(Position destination)
        {
            int moveDistanceX = destination.X - CurrentPosition.X; //Si se mueve siempre cero, si come, 1 o -1
            int moveDistanceY = destination.Y - CurrentPosition.Y; //peon blanco=1 o 2 || Peon negro=-1 o -2 dependiendo de si es su primer movimiento

            //----INICIO DE BLOQUE DE CODIGO TEMPORAL (Más adelante se delegara a la clase BOARD)--------------------------

            if (!Funcs.OutOfBoard(destination))
            {
                return false;
            }

            //----FIN DE BLOQUE DE CODIGO TEMPORAL ------------------------------------------------------------------------

            if (moveDistanceX != 0)
            {
                //temporal hasta implementar la captura de piezas
                return false;
            }

            //Lógica de movimientos de peón blanco
            if (Color == PieceColor.White)
            {
                if (moveDistanceY == 1)
                {
                    return true;
                }
                if (moveDistanceY == 2 && isFirstMove)
                {
                    return true;
                }
            }

            //Lógica de movimientos de peón negro
            if (Color == PieceColor.Black)
            {
                if (moveDistanceY == -1)
                {
                    return true;
                }
                if (moveDistanceY == -2 && isFirstMove)
                {
                    return true;
                }
            }
            return false;
        }
    }
}