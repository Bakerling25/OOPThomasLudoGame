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
            foreach (Player player in players)
            {
                PlayTurn(player);
            }
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
            Console.WriteLine("Det er din " + player.Name);
        }
        public bool IsItSix(int diceNum)
        {

        }
       
    }
}
