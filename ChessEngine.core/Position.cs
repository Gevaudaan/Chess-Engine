using System;
using System.Collections.Generic;
using System.Text;

namespace ChessEngineCore
{
    public struct Position 
    {
        //Creamos la estructura Position que con las variables de las coordenadas el eje X e Y
        public int X { get; private set; }
        public int Y { get; private set; }

        //Creamos un constructor de posiciones bidimensional que almacena la posición de una pieza en el eje X e Y
        public Position(int x, int y)
        {
            X = x;
            Y = y;
            
        }

        
    }
    
}
