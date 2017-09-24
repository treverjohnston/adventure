using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Game Game = new Game();
            System.Console.WriteLine("Welcome Adventurer, what is your name?");
            string Name = Console.ReadLine();
            Console.Clear();
            Game.Setup(Name);
        }
    }
}
