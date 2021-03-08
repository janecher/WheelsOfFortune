using System;
using System.Collections.Generic;
using System.Text;

namespace WheelsOfFortune
{
    public class Play
    {
        private string[] words = new string[] { "apple", "banana", "orange", "cucumber", "strawberry", "blackberry" };

        public string RandomWord()
        {
            Random rand = new Random();
            int index = rand.Next(words.Length);
            return words[index];
        }

        public string MakeStringDashes(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                result.Append("-");
            }
            return result.ToString();
        }

        public bool GuessResult(char guess, string origin)
        {
            return origin.Contains(guess);
        }

        public string DashesUpdate(char guess, string origin, string dashes)
        {
            char[] dashesChars = dashes.ToCharArray();
            for (int i = 0; i < origin.Length; i++)
            {
                if (origin[i] == guess)
                {
                    dashesChars[i] = guess;
                }
            }
            return dashesChars.ToString();
        }

        public bool StopGame(string dashes)
        {
            return dashes.Contains("-");
        }
    }
}
