using ChessEngineCore;
using System;

Position startPosition = new Position(0, 1);
Pawn peonA2 = new Pawn
{
    Color = PieceColor.White,
    CurrentPosition = startPosition

};
Console.WriteLine($"Piece created: {peonA2.Color} Pawn at X:{peonA2.CurrentPosition.X}, Y:{peonA2.CurrentPosition.Y}");

// Pause to see the output
Console.ReadLine();
Console.WriteLine("Hello, World!");


