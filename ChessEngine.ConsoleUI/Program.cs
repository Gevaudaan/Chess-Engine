using ChessEngineCore;
using ChessEngineCore.Pieces;
using System;
using System.Collections;
using System.Net.NetworkInformation;

namespace ChessEngine.ConsoleUI
{
    internal class Program
    {
        private static void Main()
        {
            var boardCtrl = new BoardCtrl();
            boardCtrl.SetupBoard();
            boardCtrl.PrintBoard();
            bool isCheckmate = false;

            while (!isCheckmate)
            {
                Console.WriteLine("write the coordinate of the piece you want to move (from a1 to h8): ");
                string? sourceIndex = Console.ReadLine();
                Position position = Funcs.NormalizeIndex(sourceIndex);

                Console.WriteLine("write the coordinate of the square you want to move your piece to: ");
                string destinationIndex = Console.ReadLine();
                Position destino = Funcs.NormalizeIndex(destinationIndex);

                switch (boardCtrl.MakeMove(position, destino))
                {
                    case MoveResult.InvalidPattern:
                        Console.WriteLine("Movimiento invalido");
                        Console.WriteLine("Invalid move");
                        break;

                    case MoveResult.PathBlocked:
                        Console.WriteLine("Camino obstruido");
                        Console.WriteLine("There is a piece blocking the way!");
                        break;

                    case MoveResult.FriendlyFire:
                        Console.WriteLine("Estas intentando comer una pieza aliada!");
                        Console.WriteLine("Friendly fire will not be tolerated.");
                        break;

                    case MoveResult.SquareEmpty:
                        Console.WriteLine("La casilla seleccionada está vacío.");
                        Console.WriteLine("The seleceted square is empty.");
                        break;
                }
            }
        }
    }
}