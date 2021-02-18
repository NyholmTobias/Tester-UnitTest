using System;

namespace TddExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var Game = new GameTimer();

            Console.WriteLine("Welcome.");

            string result = Game.CountDown(3);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
