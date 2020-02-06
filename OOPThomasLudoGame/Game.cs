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
        public void GetString()
        {
            foreach (Player player in playerCreator.PlayerCreating(NamePlayerList(numberOfPlayers), PieceCreator.CreatePiece()))
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
