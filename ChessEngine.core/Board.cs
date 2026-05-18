using System;
using System.Collections.Generic;
using System.Text;
using ChessEngineCore;
using ChessEngineCore.Pieces;

namespace ChessEngineCore
{
    public class BoardCtrl
    {
        private Piece?[] Board = new Piece?[128];

        public Piece?[] SetupBoard()
        {

            Board[0] = new Rook(PieceColor.White, 'R');
            Board[1] = new Knight(PieceColor.White, 'N');
            Board[2] = new Bishop(PieceColor.White, 'B');
            Board[3] = new Queen(PieceColor.White, 'Q');
            Board[4] = new King(PieceColor.White, 'K');
            Board[5] = new Bishop(PieceColor.White, 'B');
            Board[6] = new Knight(PieceColor.White, 'N');
            Board[7] = new Rook(PieceColor.White, 'R');
            

            for (int i = 8; i <= 127;i++) 
            {
                if (i > 15 && i <= 23)
                {
                    Board[i] = new Pawn(PieceColor.White, 'P');
                }
                else if (i >= 96 && i <= 103)
                {
                    Board[i] = new Pawn(PieceColor.Black, 'p');
                }
                else
                {
                    Board[i] = null;
                }
            }
            Board[112] = new Rook(PieceColor.Black, 'r');
            Board[113] = new Knight(PieceColor.Black, 'n');
            Board[114] = new Bishop(PieceColor.Black, 'b');
            Board[115] = new Queen(PieceColor.Black, 'q');
            Board[116] = new King(PieceColor.Black, 'k');
            Board[117] = new Bishop(PieceColor.Black, 'b');
            Board[118] = new Knight(PieceColor.Black, 'n');
            Board[119] = new Rook(PieceColor.Black, 'r');


            return Board;
        }
        public void printBoard()
        {
            for(int i=0; i <= 127; i++)
            {
                if (Board[i] != null)
                {
                    Console.Write(Board[i]!.Symbol);
                }
                else
                {
                    Console.Write('.');
                }

            }
        }

    }
}
