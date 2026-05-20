using ChessEngineCore;
using ChessEngineCore.Pieces;
using System;
using System.Collections;
using System.Net.NetworkInformation;
class Program
{
    static void Main()
    {
        Position position = new Position(2,0);
        var boardCtrl = new BoardCtrl(); 
        boardCtrl.SetupBoard();
        boardCtrl.PrintBoard();

        Console.ReadLine();

    }
}


