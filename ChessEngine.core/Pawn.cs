using System;
using System.Collections.Generic;
using System.Text;
using ChessEngineCore;

namespace ChessEngineCore
{
    public class Pawn : Piece 
    {
        public bool FirstMove { get; private set; }
        public override bool IsValidMove(Position destination)
        {
            int moveDistanceY = destination.Y - CurrentPosition.Y; //peon blanco=1 o 2 || Peon negro=-1 o -2 dependiendo de si es su primer movimiento
            int moveDistanceX = destination.X - CurrentPosition.X; //Si se mueve siempre cero, si come, 1 o -1

            if (destination.Y<0 || destination.Y > 7) //Revisamos que la coordenada Y no se salga del tablero
            {
                return false;
            }
            if (destination.X < 0 || destination.X > 7)//Revisamos que la coordenada X no se salga del tablero
            {
                return false;
            }
            if (moveDistanceX != 0)
            {
                //temporal hasta implementar la captura de piezas
                return false;
            }
            

            if (Color == PieceColor.White)
            {
                if (moveDistanceY == 1)
                {
                    return true;
                }
                if(moveDistanceY == 2 && FirstMove)
                {
                    return true;
                }
            }

            if (Color == PieceColor.Black)
            {
                if (moveDistanceY == -1)
                {
                    return true;
                }
                if (moveDistanceY == -2 && FirstMove)
                {
                    return true;
                }
            }
            return false;
        }
        public override int PosibleMoves(Position destination)
        {

            return 0;
        }
    }
}
