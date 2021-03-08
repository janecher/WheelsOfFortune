using System;
using System.Collections.Generic;
using System.Text;

namespace WheelsOfFortune
{
    public class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public char GetGuessLetter()
        {
            Console.WriteLine("Guess letter?");
            string letter = Console.ReadLine();
            if (!Validation(letter))
            {
                return GetGuessLetter();
            }
            else
            {
                return letter.ToLower()[0];
            }
        }

        private bool Validation(string input)
        {
            if (input.Length != 1)
            {
                Console.WriteLine("Incorrect input. Only 1 letter allow.");
                return false;
            }
            if (!char.IsLetter(input[0]))
            {
                Console.WriteLine("Incorrect input. Only letters allow.");
                return false;
            }
            return true;
        }
    }
}
