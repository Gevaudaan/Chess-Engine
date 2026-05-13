using System;
using System.Collections.Generic;
using System.Text;

namespace ChessEngineCore
{
    public static class FuncionesUtiles
    {
        public static bool OutOfBoard(Position destination)
        {
            if (destination.X < 0 || destination.X > 7)//Revisamos que la coordenada X no se salga del tablero
            {
                return false;
            }

            if (destination.Y < 0 || destination.Y > 7) //Revisamos que la coordenada Y no se salga del tablero
            {
                return false;
            }
            return true;
        }
    }
}
