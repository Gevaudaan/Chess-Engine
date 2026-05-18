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
        Piece[] board = boardCtrl.SetupBoard();
        boardCtrl.printBoard();
        Console.ReadLine();
    }
}


