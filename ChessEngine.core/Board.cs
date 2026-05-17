using System;
using System.Collections.Generic;
using System.Text;
using ChessEngineCore;
using ChessEngineCore.Pieces;

namespace ChessEngineCore
{
    internal class BoardCtrl
    {
        private Piece[] Board = new Piece[128];

        public Piece[] SetupBoard()
        {

            Board[0] = new Rook(PieceColor.White);
            Board[1] = new Knight(PieceColor.White);
            Board[2] = new Bishop(PieceColor.White);
            Board[3] = new Queen(PieceColor.White);
            Board[4] = new King(PieceColor.White);
            Board[5] = new Bishop(PieceColor.White);
            Board[6] = new Knight(PieceColor.White);
            Board[7] = new Rook(PieceColor.White);
            

            for (int i = 8; i <= 127;i++) 
            {
                if (i > 15 && i <= 23)
                {
                    Board[i] = new Pawn(PieceColor.White);
                }
                else if (i >= 96 && i <= 103)
                {
                    Board[i] = new Pawn(PieceColor.Black);
                }
                else
                {
                    Board[i] = null;
                }
            }
            Board[112] = new Rook(PieceColor.Black);
            Board[113] = new Knight(PieceColor.Black);
            Board[114] = new Bishop(PieceColor.Black);
            Board[115] = new Queen(PieceColor.Black);
            Board[116] = new King(PieceColor.Black);
            Board[117] = new Bishop(PieceColor.Black);
            Board[118] = new Knight(PieceColor.Black);
            Board[119] = new Rook(PieceColor.Black);


            return Board;
        }

    }
}
