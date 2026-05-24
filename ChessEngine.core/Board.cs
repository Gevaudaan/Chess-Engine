using System;
using System.Collections.Generic;
using System.Text;
using ChessEngineCore;
using ChessEngineCore.Pieces;

namespace ChessEngineCore
{
    public class BoardCtrl
    {
        private readonly Piece?[] _board = new Piece?[128]; // new array that stores the Pieces and nulls

        public void SetupBoard() //Function that sets up the board, assigning pieces to their respective index
        {
            _board[0] = new Rook(PieceColor.White, "R ");
            _board[1] = new Knight(PieceColor.White, "N ");
            _board[2] = new Bishop(PieceColor.White, "B ");
            _board[3] = new Queen(PieceColor.White, "Q ");
            _board[4] = new King(PieceColor.White, "K ");
            _board[5] = new Bishop(PieceColor.White, "B ");
            _board[6] = new Knight(PieceColor.White, "N ");
            _board[7] = new Rook(PieceColor.White, "R ");

            for (int i = 16; i <= 23; i++)
            {
                _board[i] = new Pawn(PieceColor.White, "P ");
            }

            for (int i = 96; i <= 103; i++)
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

        public void PrintBoard() //Function that prints the board on the console
        {
            int counter = 8;//Counter that will indicate the index that are out of the board
            int rankCounter = 0;
            Console.WriteLine("   A B C D E F G H");

            for (int i = 0; i <= 127; i++)
            {
                if ((i - 16) % 16 == 0)
                {
                    rankCounter += 1;
                    Console.Write(" " + rankCounter + " ");
                }

                if (_board[i] != null) //print the Pieces
                {
                    Piece pieza = _board[i]!;
                    Console.Write(pieza!.Symbol);
                }
                else
                {
                    if (counter <= i) //if it's out of the board's limits, then it prints nothing.
                    {
                        Console.Write("");
                    }
                    else           //However, if it's in the board, it prints a dot.
                    {
                        Console.Write(". ");
                    }
                }

                if ((i + 1) % 16 == 0 && i != 0)
                {
                    Console.WriteLine();
                    counter += 16;//Sets the next limit of the board
                }
            }
            Console.WriteLine();
        }

        public void MakeMove(Position sourceIndex2D, Position Destination2D)
        {
            int sourceIndex = Funcs.TwoDTo1d(sourceIndex2D); //we turn the 2D index of the piece we want to move and the index of it's destination into 1D index
            int Destination = Funcs.TwoDTo1d(Destination2D);

            Console.WriteLine("Español: La casilla seleccionada es: " + sourceIndex);
            Console.WriteLine("Español: La casilla destino seleccionada es: " + Destination);

            Type? pieceToMove = _board[sourceIndex]?.GetType(); //PieceToMove contains the type of piece (the name of the class) that user tried to move
            
            if (pieceToMove == null)
            {
                Console.WriteLine("Español: La casilla seleccionada está vacío.");
                Console.WriteLine("English: The seleceted square is empty.");
                return;
            }
            Console.WriteLine($"La pieza a mover es un/a: {pieceToMove.Name}");
            if (_board[sourceIndex].IsValidMove(Destination2D, sourceIndex2D))
            {
                _board[Destination] = _board[sourceIndex];
                _board[sourceIndex] = null;
                PrintBoard();
                return;
            }
            else
            {
                Console.WriteLine("Movimiento invalido");
                return;
            }
        }
    }
}