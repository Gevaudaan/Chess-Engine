using ChessEngineCore;
using ChessEngineCore.Pieces;
using System;
using System.Collections;
using System.Net.NetworkInformation;
class Program
{
    static void Main()
    {
        var boardCtrl = new BoardCtrl(); 
        boardCtrl.SetupBoard();
        boardCtrl.PrintBoard();
        Console.ReadLine();
    }
}


