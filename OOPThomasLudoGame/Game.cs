using System;
using System.Collections.Generic;
using System.Text;

namespace OOPThomasLudoGame
{
    class Game
    {
        private int numberOfPlayers;
        List<string> names = new List<string>();
        List<Player> players = new List<Player>();
        PlayerCreator playerCreator = new PlayerCreator();
        public void Play()
        {
            numberOfPlayers = int.Parse(Console.ReadLine());
            players = playerCreator.PlayerCreating(NamePlayerList(numberOfPlayers), PieceCreator.CreatePiece());
            do
            {
                foreach (Player player in players)
                {
                    PlayTurn(player);
                }

            } while (IsGameFinished(players) == false);
        }
        public List<string> NamePlayerList(int numberOfPlayer)
        {
            string name;
            for (int i = 0; i < numberOfPlayer; i++)
            {
                Console.WriteLine("Skriv navnet på spiller " + i);
                name = Console.ReadLine();
                names.Add(name);
            }
            return names;
        }
        public void PlayTurn(Player player)
        {
            int diceNum;
            PrintPlayer(player);
            if (player.HasPlayerPieceOnBoard)
            {
                diceNum = Dice.GetDiceThrow();
                PrintDiceAndPlayer(player, diceNum);
                if (IsItSix(diceNum))
                {
                    Console.WriteLine("Hvilken brik vil du flytte med " + player.Name);
                    WhatPieceMove(player,PlayerChoice(player));
                    //Sæt brikken på spillebrætet
                }
                else
                {

                }
            }
            else if (player.HasPlayerPieceOnBoard == false)
            {
                for (int i = 0; i < 2; i++)
                {
                    diceNum = Dice.GetDiceThrow();
                    if (IsItSix(diceNum))
                    {
                        Console.WriteLine(player.Name + " har slået en " + diceNum);
                        WhatPieceMove(player,PlayerChoice(player));
                        break;
                    }
                }
            }
                
                    //må kun slå med terning en gang
                //nej
                    //skal slå med terning maks 3 gange, men dog kun indtil spilleren har slået seks
            //er terninge slaget en sekser
                //ja 
                    
        }
        public bool IsItSix(int diceNum)
        {
            if (diceNum == 6)
            {
                return true;
            }
            return false;
        }
        public void WhatPieceMove(Player player, int pieceNum)
        {
            player.HasPlayerPieceOnBoard = true;
            foreach (Piece piece in player.Pieces)
            {
                if (piece.PieceNumber == pieceNum)
                {
                    piece.Position = 1;
                    Console.WriteLine(piece.PieceNumber + " er ny på brættet");
                }
            }
        }
        public int PlayerChoice(Player player)
        {
            int playerChoice;
            Console.WriteLine("Hvilken brik skal på brætte " + player.Name);
            return playerChoice = int.Parse(Console.ReadLine());
        }
        public void PrintDiceAndPlayer(Player player, int diceNum)
        {
            Console.WriteLine(player.Name + " har slået " + diceNum);
        }
        public void PrintPlayer(Player player)
        {
            Console.WriteLine("Det er din tur " + player.Name);
        }
        public bool IsGameFinished(List<Player> players)
        {
            int counter = 0;
            foreach (Player player in players)
            {
                if (player.HasPlayerWon)
                {
                    counter++;
                    if (counter == players.Count -1)
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }
       
    }
}
