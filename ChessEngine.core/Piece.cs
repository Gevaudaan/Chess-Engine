using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Transactions;

namespace ChessEngineCore
{
    public abstract class Piece
    {
        //Definimos los atributos de la clase padre, Piece,
        private bool Alive { get; set; } //Si la pieza sigue viva o no
        public PieceColor Color { get; set; } 
        public Position CurrentPosition { get; set; }

        //CONSTRUCTOR
        public Piece(PieceColor color)
        {
            Color = color;
            
        }
        //public abstract int PosibleMoves(Position destination); //Funcion que calculara los posibles movimientos pasandole la coordenada del lugar adonde ir
        public abstract bool IsValidMove(Position destination); //Funcion que definira si el movimiento es válido o no
        //public abstract bool IsValidMove(Position destination, Position CurrentPosition); //Misma función pero para pruebas
    }
}
