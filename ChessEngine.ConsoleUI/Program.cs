using ChessEngineCore;
using System;
using System.Collections;
using System.Net.NetworkInformation;
/*
Position startPosition = new Position(2, 0);
Position destination = new Position(4, 2);
Pawn peonB2 = new Pawn(PieceColor.White);
Bishop alfilC1 = new Bishop(PieceColor.White);
//Console.WriteLine("El movimiento del Peon B2 puede moverse a la posicion " + destination + "? "+peonB2.IsValidMove(destination, startPosition));
//Console.WriteLine("El movimiento del alfil C1 puede moverse a la posición "+destination+"? "+alfilC1.IsValidMove(destination, startPosition));
*/

// --- 1. TORRE (Rook) ---
Position startRook = new Position(0, 0); // A1
Rook rookA1 = new Rook(PieceColor.White);

// Coordenadas True: (0, 7) [A8 - misma columna], (7, 0) [H1 - misma fila]
// Coordenadas False: (1, 1) [B2 - diagonal], (2, 3) [Salto aleatorio]
Position destRookTrue = new Position(0, 7);
Position destRookFalse = new Position(1, 1);

Console.WriteLine("Torre A1 a A8 (Debería ser True): " + rookA1.IsValidMove(destRookTrue, startRook));
Console.WriteLine("Torre A1 a B2 (Debería ser False): " + rookA1.IsValidMove(destRookFalse, startRook));
Console.WriteLine("--------------------------------------------------");


// --- 2. CABALLO (Knight) ---
Position startKnight = new Position(1, 0); // B1
Knight knightB1 = new Knight(PieceColor.White);

// Coordenadas True: (2, 2) [C3 - 1 en X, 2 en Y], (0, 2) [A3 - -1 en X, 2 en Y]
// Coordenadas False: (1, 2) [B3 - movimiento recto], (3, 3) [D4 - diagonal]
Position destKnightTrue = new Position(2, 2);
Position destKnightFalse = new Position(1, 2);

Console.WriteLine("Caballo B1 a C3 (Debería ser True): " + knightB1.IsValidMove(destKnightTrue, startKnight));
Console.WriteLine("Caballo B1 a B3 (Debería ser False): " + knightB1.IsValidMove(destKnightFalse, startKnight));
Console.WriteLine("--------------------------------------------------");


// --- 3. REINA (Queen) ---
Position startQueen = new Position(3, 0); // D1
Queen queenD1 = new Queen(PieceColor.White);

// Coordenadas True: (3, 7) [D8 - recto vertical], (7, 4) [H5 - diagonal perfecta]
// Coordenadas False: (4, 2) [E3 - salto de caballo], (5, 1) [F2 - salto aleatorio]
Position destQueenTrue = new Position(7, 4);
Position destQueenFalse = new Position(4, 2);

Console.WriteLine("Reina D1 a H5 (Debería ser True): " + queenD1.IsValidMove(destQueenTrue, startQueen));
Console.WriteLine("Reina D1 a E3 (Debería ser False): " + queenD1.IsValidMove(destQueenFalse, startQueen));
Console.WriteLine("--------------------------------------------------");


// --- 4. REY (King) ---
Position startKing = new Position(4, 0); // E1
King kingE1 = new King(PieceColor.White);

// Coordenadas True: (4, 1) [E2 - arriba], (5, 1) [F2 - diagonal arriba-derecha]
// Coordenadas False: (4, 2) [E3 - dos pasos arriba], (2, 0) [C1 - salto largo]
Position destKingTrue = new Position(5, 1);
Position destKingFalse = new Position(4, 2);

Console.WriteLine("Rey E1 a F2 (Debería ser True): " + kingE1.IsValidMove(destKingTrue, startKing));
Console.WriteLine("Rey E1 a E3 (Debería ser False): " + kingE1.IsValidMove(destKingFalse, startKing));
Console.WriteLine("--------------------------------------------------");


// --- 5. PEÓN (Pawn - Blanco) ---
Position startWhitePawn = new Position(0, 1); // A2
Pawn whitePawn = new Pawn(PieceColor.White);

// Coordenadas True: (0, 2) [A3 - un paso adelante], (0, 3) [A4 - dos pasos, primer movimiento]
// Coordenadas False: (0, 4) [A5 - tres pasos], (1, 2) [B3 - diagonal sin capturar]
Position destWhitePawnTrue = new Position(0, 2);
Position destWhitePawnFalse = new Position(1, 2);

Console.WriteLine("Peón Blanco A2 a A3 (Debería ser True): " + whitePawn.IsValidMove(destWhitePawnTrue, startWhitePawn));
Console.WriteLine("Peón Blanco A2 a B3 (Debería ser False): " + whitePawn.IsValidMove(destWhitePawnFalse, startWhitePawn));
Console.WriteLine("--------------------------------------------------");


// --- 6. PEÓN (Pawn - Negro) ---
// Nota: El peón negro resta en Y (-1 o -2)
Position startBlackPawn = new Position(0, 6); // A7
Pawn blackPawn = new Pawn(PieceColor.Black);

// Coordenadas True: (0, 5) [A6 - un paso abajo], (0, 4) [A5 - dos pasos abajo]
// Coordenadas False: (0, 7) [A8 - yendo hacia atrás], (1, 5) [B6 - diagonal sin capturar]
Position destBlackPawnTrue = new Position(0, 5);
Position destBlackPawnFalse = new Position(0, 7);

Console.WriteLine("Peón Negro A7 a A6 (Debería ser True): " + blackPawn.IsValidMove(destBlackPawnTrue, startBlackPawn));
Console.WriteLine("Peón Negro A7 a A8 (Debería ser False): " + blackPawn.IsValidMove(destBlackPawnFalse, startBlackPawn));

Console.ReadLine();



