using ChessEngineCore;
using System;

Position startPosition = new Position(2, 0);
Position destination = new Position(4, 2);
Pawn peonB2 = new Pawn(PieceColor.White);
Bishop alfilC1 = new Bishop(PieceColor.White);
//Console.WriteLine("El movimiento del Peon B2 puede moverse a la posicion " + destination + "? "+peonB2.IsValidMove(destination, startPosition));
//Console.WriteLine("El movimiento del alfil C1 puede moverse a la posición "+destination+"? "+alfilC1.IsValidMove(destination, startPosition));
Console.WriteLine($"Piece created: {peonB2.Color} Pawn at X:{startPosition.X}, Y:{startPosition.Y}");

Console.ReadLine();



