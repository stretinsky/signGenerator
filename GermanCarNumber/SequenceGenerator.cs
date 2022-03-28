using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GermanCarNumber
{
    internal class SequenceGenerator
    {
        private static char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private List<string> numbers = new List<string>();
        private StringBuilder sequence = new StringBuilder();
        private Random rand = new Random();
        public string CreateRandomNumber()
        {
            sequence.Clear();
            int countOfFirstSymbols = rand.Next(1, 4);
            for (int i = 0; i < countOfFirstSymbols; i++)
            {
                sequence.Append(alphabet[rand.Next(alphabet.Length)]);
            }
            sequence.Append(" ");
            countOfFirstSymbols = rand.Next(1, 3);
            for (int i = 0; i < countOfFirstSymbols; i++)
            {
                sequence.Append(alphabet[rand.Next(alphabet.Length)]);
            }
            sequence.Append(" ");
            countOfFirstSymbols = rand.Next(1, 11 - sequence.Length);
            for (int i = 0; i < countOfFirstSymbols; i++)
            {
                sequence.Append(rand.Next(10));
            }
            return sequence.ToString();
        }
    }
}
