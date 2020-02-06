using System;

namespace OOPThomasLudoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvor mange spillere? ");
            Game game = new Game();
            game.Play();
            Console.ReadLine();
        }
    }
}
