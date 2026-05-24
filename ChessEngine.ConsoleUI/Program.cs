using ChessEngineCore;
using ChessEngineCore.Pieces;
using System;
using System.Collections;
using System.Net.NetworkInformation;

internal class Program
{
    private static void Main()
    {
        //Position position = new Position(2,0);
        //Position destino = new Position(4, 2);
        var boardCtrl = new BoardCtrl();
        boardCtrl.SetupBoard();
        boardCtrl.PrintBoard();

        Console.WriteLine("write the coordinate of the piece you want to move (from a1 to h8): ");
        string SourceIndex = Console.ReadLine();//a2
        Position position = Funcs.NormalizeIndex(SourceIndex);//

        Console.WriteLine("write the coordinate of the square you want to move your piece to: ");
        string DestinationIndex = Console.ReadLine();
        Position destino = Funcs.NormalizeIndex(DestinationIndex);
        boardCtrl.MakeMove(position, destino);
        Console.ReadLine();

        //Console.WriteLine("write the coordinate of the piece you want to move (from a1 to h8): ");
        //string SourceIndex = Console.ReadLine();//a2
        //Position position = Funcs.NormalizeIndex(SourceIndex);//
    }
}