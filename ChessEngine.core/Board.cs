using System;
using System.Collections.Generic;
using System.Text;
using ChessEngineCore;
using ChessEngineCore.Pieces;

namespace ChessEngineCore
{
    public enum MoveResult
    {
        Success,
        SquareEmpty,
        InvalidPattern,
        PathBlocked,
        FriendlyFire
    }

    public class BoardCtrl
    {
        private readonly Piece?[] _board = new Piece?[128]; // new array that stores the Pieces and nulls
        private bool isWhitesTurn = true;

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
            int counter= 8;//Counter that will indicate the index that are out of the board
            int rankCounter;
            int start ;
            int end;
            int op;
            string letters;
            
            if (isWhitesTurn)
            {
                start = 0;
                end = 127;
                op = 1;
                rankCounter = 0;
                letters = "    a b c d e f g h";
                counter = 8;
            }
            else
            {
                start = -127;
                end = 0;
                op = -1;
                rankCounter = 9;
                letters = "    h g f e d c b a";
                counter = -120;
            }
            int i2 = 0;
            Console.WriteLine(letters);
            Console.WriteLine("  ┌─────────────────┐");
                for (int i = start; i <= end; i += 1)
                {
                
                    if ((i2 - 16) % 16 == 0)
                    {
                        rankCounter += 1*op;
                        Console.Write(" " + rankCounter + "│ ");
                    }

                    if (_board[i*op] != null) //print the Pieces
                    {
                        Piece pieza = _board[i * op]!;
                        Console.Write(pieza!.Symbol);
                    }
                    else
                    {
                        if (counter <= i) //if it's out of the board's limits, then it prints nothing. //i va de -127 a 0 de 1 a 1 y counter va de -135 y se le suma 16 cada 16 posiciones
                        {
                            Console.Write("");
                        }
                        else           //However, if it's in the board, it prints a dot.
                        {
                            Console.Write(". ");
                        }
                    }

                    if ((i2 + 1) % 16 == 0 && i2 != 0)
                    {
                        Console.WriteLine("│");
                        counter += 8;//Sets the next limit of the board
                        
                    }
                    i2 += 1;
                    
                }
                
       

            Console.WriteLine("  └─────────────────┘");
        }

        public MoveResult MakeMove(Position sourceIndex2D, Position destination2D)
        {
            int sourceIndex = Funcs.TwoDTo1d(sourceIndex2D); //we turn the 2D index of the piece we want to move and the index of it's destination into 1D index
            int destination = Funcs.TwoDTo1d(destination2D);

            Piece? piece = _board[sourceIndex];
            Piece? destinationPiece = _board[destination];

            if (piece == null)
            {
                return MoveResult.SquareEmpty;
            }

            if (destinationPiece != null && piece.Color == destinationPiece.Color)
            {
                return MoveResult.FriendlyFire;
            }

            if (!IsPathClear(sourceIndex2D, destination2D))
            {
                return MoveResult.PathBlocked;
            }

            //Console.WriteLine($"La pieza a mover es un/a: {piece.GetType().Name}");
            if (piece.IsValidMove(destination2D, sourceIndex2D) && IsPathClear(sourceIndex2D, destination2D))
            {
                _board[destination] = piece;
                _board[sourceIndex] = null;
                isWhitesTurn=!isWhitesTurn;
                PrintBoard();
                return MoveResult.Success;
            }
            else
            {
                return MoveResult.InvalidPattern;
            }
        }

        private bool IsPathClear(Position sourceIndex2D, Position destination2D)
        {
            int sourceIndex = Funcs.TwoDTo1d(sourceIndex2D); //we turn the 2D index of the piece we want to move and the index of it's destination into 1D index
            int destination = Funcs.TwoDTo1d(destination2D);
            Piece? piece = _board[sourceIndex];

            if (piece is Knight)
            {
                return true;
            }
            //The Math.Sign() method returns an integer that indicates whether a number is positive, negative, or zero.
            int stepX = Math.Sign(destination2D.X - sourceIndex2D.X); // >0=1 Going to the right, <0=-1 going to the left, 0=0 doensn't move in the X axis
            int stepY = Math.Sign(destination2D.Y - sourceIndex2D.Y);//>0=1 Going forward, <0=-1 going backwards, 0=0 doensn't move in the Y axis
            int indexStep = (stepY * 16 + stepX);
            int currentIndex = sourceIndex + indexStep;

            while (currentIndex != destination)
            {
                if (_board[currentIndex] != null)
                {
                    return false;
                }
                currentIndex += indexStep;
            }

            return true;
        }
    }
}