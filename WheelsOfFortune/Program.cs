using System;

namespace WheelsOfFortune
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! You are playing Wheels Of Fortune!");
            Console.WriteLine("Please input your name:");
            string name = Console.ReadLine();
            Player player = new Player(name);
            Console.WriteLine($"Ok {name}, let's start!");

            Play play = new Play();
            string origin = play.RandomWord();
            string dashes = play.MakeStringDashes(origin);

            Console.WriteLine(dashes);

            int numberOfGuessing = 0;
            while (!play.StopGame(dashes))
            {
                char guess = player.GetGuessLetter();
                if (play.GuessResult(guess, origin))
                {
                    dashes = play.DashesUpdate(guess, origin, dashes);
                }
                else
                {
                    Console.WriteLine("Your guess is not in the word.");
                }
                Console.WriteLine(dashes);
                numberOfGuessing++;
            }
            Console.WriteLine($"You did this in {numberOfGuessing} turns!");
            Console.ReadKey();
        }
    }
}
