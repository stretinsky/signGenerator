using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GermanCarNumber
{
    internal class SequenceGenerator
    {
        private string[] regions;
        private ushort regionIndex = 0;

        private ushort lettersIndex = 0;
        private List<string> letters = new List<string>();

        private int numbers = 1;

        private static char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private List<string> carNumbers = new List<string>();
        private StringBuilder sequence = new StringBuilder("A A 1");
        private Random rand = new Random();
        public SequenceGenerator()
        {
            regions = Properties.Resources.regions.Split('\n');
            for (int i = 0; i < regions.Length; i++)
            {
                regions[i] = regions[i].Substring(0, regions[i].IndexOf(':'));
                regions[i].Replace('Ü', 'ü');//пока не работает
                regions[i].Replace('Ö', 'ö');
            }
            for (int i = 0; i < alphabet.Length; i++)
            {
                letters.Add(alphabet[i].ToString());
                for (int j = 0; j < alphabet.Length; j++)
                {
                    letters.Add(alphabet[i].ToString() + alphabet[j].ToString());
                }
            }
            letters.Remove("SS");
            letters.Remove("SA"); //добавлю список запрещенных комбинаций, и буду нормально это делать
            letters.Remove("RE");
        }
        public string CreateRandomNumber()
        {
            sequence.Clear();
            regionIndex = (ushort)rand.Next(regions.Length);
            lettersIndex = (ushort)rand.Next(letters.Count);
            sequence.Append(regions[regionIndex] + " " + letters[lettersIndex] + " ");

            numbers = sequence.Length.Equals(7) ? rand.Next(1, 1000) : rand.Next(1, 10000);
            sequence.Append(numbers);
            if (carNumbers.Contains(sequence.ToString())) return CreateRandomNumber();
            carNumbers.Add(sequence.ToString());
            return sequence.ToString();
        }
        public string CreateRandomNumber(string region)
        {
            sequence.Clear();
            try
            {
                regionIndex = (ushort)Array.IndexOf(regions, region);
            }
            catch
            {
                regionIndex = (ushort)rand.Next(regions.Length);
            }
            lettersIndex = (ushort)rand.Next(letters.Count);
            sequence.Append(regions[regionIndex] + " " + letters[lettersIndex] + " ");

            numbers = sequence.Length.Equals(7) ? rand.Next(1, 1000) : rand.Next(1, 10000);
            sequence.Append(numbers);
            if (carNumbers.Contains(sequence.ToString())) return CreateRandomNumber();
            carNumbers.Add(sequence.ToString());
            return sequence.ToString();
        }
        public string CreateNextNumber()
        {
            if (numbers + 1 >= 10000 || numbers + 1 >= 1000 && sequence.Replace(numbers.ToString(), (numbers + 1).ToString()).Length >= 11)
            {
                if (lettersIndex.Equals((ushort)(letters.Count - 1)))
                {
                    if (regionIndex.Equals(regions.Length - 1)) return null;
                    numbers = 1;
                    lettersIndex = 0;
                    sequence.Clear();
                    sequence.Append($"{regions[++regionIndex]} {letters[lettersIndex]} {numbers}");

                    if (carNumbers.Contains(sequence.ToString())) return CreateNextNumber();
                    carNumbers.Add(sequence.ToString());
                    return sequence.ToString();
                }
                numbers = 1;
                sequence.Clear();
                sequence.Append($"{regions[regionIndex]} {letters[++lettersIndex]} {numbers}");

                if (carNumbers.Contains(sequence.ToString())) return CreateNextNumber();
                carNumbers.Add(sequence.ToString());
                return sequence.ToString();
            }
            else
            {
                sequence.Replace(numbers.ToString(), (++numbers).ToString());

                if (carNumbers.Contains(sequence.ToString())) return CreateNextNumber();
                carNumbers.Add(sequence.ToString());
                return sequence.ToString();
            }
        }
        public string CreateNextNumber(string region)
        {
            if (numbers + 1 >= 10000 || numbers + 1 >= 1000 && sequence.Replace(numbers.ToString(), (numbers + 1).ToString()).Length >= 11)
            {
                if (lettersIndex.Equals((ushort)(letters.Count - 1))) return null;
                numbers = 1;
                sequence.Clear();
                sequence.Append($"{regions[regionIndex]} {letters[++lettersIndex]} {numbers}");

                if (carNumbers.Contains(sequence.ToString())) return CreateNextNumber(region);
                carNumbers.Add(sequence.ToString());
                return sequence.ToString();
            }
            else
            {
                sequence.Replace(numbers.ToString(), (++numbers).ToString());

                if (carNumbers.Contains(sequence.ToString())) return CreateNextNumber(region);
                carNumbers.Add(sequence.ToString());
                return sequence.ToString();
            }
        }
        public string CreatePreviousNumber()
        {
            if (numbers - 1 <= 0)
            {
                if (lettersIndex.Equals(0))
                {
                    if (regionIndex.Equals(0)) return null;
                    lettersIndex = (ushort)(letters.Count - 1);
                    sequence.Clear();
                    sequence.Append($"{regions[--regionIndex]} {letters[lettersIndex]} ");
                    numbers = sequence.Length.Equals(7) ? 999 : 9999;
                    sequence.Append(numbers);

                    if (carNumbers.Contains(sequence.ToString())) return CreatePreviousNumber();
                    carNumbers.Add(sequence.ToString());
                    return sequence.ToString();
                }
                sequence.Clear();
                sequence.Append($"{regions[regionIndex]} {letters[--lettersIndex]} ");
                numbers = sequence.Length.Equals(7) ? 999 : 9999;
                sequence.Append(numbers);

                if (carNumbers.Contains(sequence.ToString())) return CreatePreviousNumber();
                carNumbers.Add(sequence.ToString());
                return sequence.ToString();
            }
            else
            {
                sequence.Replace(numbers.ToString(), (--numbers).ToString());

                if (carNumbers.Contains(sequence.ToString())) return CreatePreviousNumber();
                carNumbers.Add(sequence.ToString());
                return sequence.ToString();
            }
        }
        public string CreatePreviousNumber(string region)
        {
            if (numbers - 1 <= 0)
            {
                if (lettersIndex.Equals(0)) return null;
                sequence.Clear();
                sequence.Append($"{regions[regionIndex]} {letters[--lettersIndex]} ");
                numbers = sequence.Length.Equals(7) ? 999 : 9999;
                sequence.Append(numbers);

                if (carNumbers.Contains(sequence.ToString())) return CreatePreviousNumber(region);
                carNumbers.Add(sequence.ToString());
                return sequence.ToString();
            }
            else
            {
                sequence.Replace(numbers.ToString(), (--numbers).ToString());

                if (carNumbers.Contains(sequence.ToString())) return CreatePreviousNumber(region);
                carNumbers.Add(sequence.ToString());
                return sequence.ToString();
            }
        }
        public List<string> GetCarNumbers()
        {
            return carNumbers;
        }
    }
}