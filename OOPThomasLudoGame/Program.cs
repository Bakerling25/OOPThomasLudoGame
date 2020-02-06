using System;

namespace OOPThomasLudoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvor mange spillere? ");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            Game game = new Game();
            game.NumberOfPlayers = numberOfPlayers;
        }
    }
}
