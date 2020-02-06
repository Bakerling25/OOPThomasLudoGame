using System;
using System.Collections.Generic;
using System.Text;

namespace OOPThomasLudoGame
{
    class PlayerCreator
    {
        public List<Player> PlayerCreating(List<string> name, List<Piece> pieces)
        {
            List<Player> players = new List<Player>();
            for (int i = 0; i < name.Count; i++)
            {
                players.Add(new Player()
                {
                    Name = name[i],
                    Pieces = PlayerPieces(i + 1, pieces),
                    HasPlayerPieceOnBoard = false,
                    HasPlayerWon = false,
                    PlayerIndentifier = i + 1
                });
            }
            return players;
        }
        public List<Piece> PlayerPieces(int playerNum, List<Piece> allPieces)
        {
            List<Piece> player1Pieces = new List<Piece>();
            List<Piece> player2Pieces = new List<Piece>();
            List<Piece> player3Pieces = new List<Piece>();
            List<Piece> player4Pieces = new List<Piece>();
            if (playerNum == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    player1Pieces.Add(allPieces[i]);
                }
                return player1Pieces;
            }
            else if (playerNum == 2)
            {
                for (int i = 4; i < 8; i++)
                {
                    player2Pieces.Add(allPieces[i]);
                }
                return player2Pieces;
            }
            else if (playerNum == 3)
            {
                for (int i = 8; i < 12; i++)
                {
                    player3Pieces.Add(allPieces[i]);
                }
                return player3Pieces;
            }
            else
            {
                for (int i = 12; i < 16; i++)
                {
                    player4Pieces.Add(allPieces[i]);
                }
                return player4Pieces;
            }
        }
        
    }
}
