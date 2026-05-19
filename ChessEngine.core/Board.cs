using System;
using System.Collections.Generic;
using System.Text;
using ChessEngineCore;
using ChessEngineCore.Pieces;

namespace ChessEngineCore
{
    public class BoardCtrl
    {
        private Piece?[] _board = new Piece?[128];

        public void SetupBoard()
        {
            _board[0] = new Rook(PieceColor.White, "R ");
            _board[1] = new Knight(PieceColor.White, "N ");
            _board[2] = new Bishop(PieceColor.White, "B ");
            _board[3] = new Queen(PieceColor.White, "Q ");
            _board[4] = new King(PieceColor.White, "K ");
            _board[5] = new Bishop(PieceColor.White, "B ");
            _board[6] = new Knight(PieceColor.White, "N ");
            _board[7] = new Rook(PieceColor.White, "R ");
            

            for (int i = 16; i <= 23;i++) 
            {
                _board[i] = new Pawn(PieceColor.White, "P ");
            }

            for(int i=96;i<=103;i++)
            {
                _board[i] = new Pawn(PieceColor.Black, "p ");
            }
            _board[112] = new Rook(PieceColor.Black, "r ");
            _board[113] = new Knight(PieceColor.Black, "n ");
            _board[114] = new Bishop(PieceColor.Black, "b ");
            _board[115] = new Queen(PieceColor.Black, "q ");
            _board[116] = new King(PieceColor.Black, "k ");
            _board[117] = new Bishop(PieceColor.Black, "b ");
            _board[118] = new Knight(PieceColor.Black, "n ");
            _board[119] = new Rook(PieceColor.Black, "r ");
        }
        public void PrintBoard()
        {
            int counter = 8;
            for (int i=0; i <= 127; i++)
            {
                
                if (_board[i] != null)
                {
                    Piece pieza = _board[i]!;
                    Console.Write(pieza!.Symbol);
                }
                else
                {
                    if (counter<=i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                        
                }
                
                if ((i+1) % 16 == 0 && i!=0)
                {
                    Console.WriteLine();
                    counter += 16;
                }

            }
        }

    }
}
