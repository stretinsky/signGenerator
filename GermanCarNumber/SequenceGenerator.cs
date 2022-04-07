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

        private ushort numbers = 1;

        private static char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static string[] bannedCombinations = new string[] { "SS", "SA", "RE" };

        private List<string> carNumbers = new List<string>();
        private StringBuilder sequence = new StringBuilder("A A 1");
        private Random rand = new Random();
        public SequenceGenerator()
        {
            regions = Properties.Resources.regions.Split('\n');
            for (int i = 0; i < regions.Length; i++)
            {
                regions[i] = regions[i].Substring(0, regions[i].IndexOf(':'));
                regions[i] = regions[i].Replace("Ü", "ü").Replace("Ö", "ö");
            }
            for (int i = 0; i < alphabet.Length; i++)
            {
                letters.Add(alphabet[i].ToString());
                for (int j = 0; j < alphabet.Length; j++)
                {
                    letters.Add(alphabet[i].ToString() + alphabet[j].ToString());
                }
            }
            foreach (string bannedCombination in bannedCombinations)
            {
                letters.Remove(bannedCombination);
            }
        }
        public string CreateRandomNumber()
        {
            sequence.Clear();
            regionIndex = (ushort)rand.Next(regions.Length);
            lettersIndex = (ushort)rand.Next(letters.Count);
            sequence.Append(regions[regionIndex] + " " + letters[lettersIndex] + " ");

            numbers = (ushort)(sequence.Length.Equals(7) ? rand.Next(1, 1000) : rand.Next(1, 10000));
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

            numbers = (ushort)(sequence.Length.Equals(7) ? rand.Next(1, 1000) : rand.Next(1, 10000));
            sequence.Append(numbers);
            if (carNumbers.Contains(sequence.ToString())) return CreateRandomNumber(region);
            carNumbers.Add(sequence.ToString());
            return sequence.ToString();
        }
        public string CreateNextNumber()
        {
            ushort nextNumbers = numbers, nLettersIndex = lettersIndex, nRegionIndex = regionIndex;
            do
            {
                if (nextNumbers == 9999 || nextNumbers == 999 && sequence.Length == 10)
                {
                    if (nLettersIndex == letters.Count - 1)
                    {
                        if (nRegionIndex == regions.Length - 1) return null;
                        nextNumbers = 1;
                        nLettersIndex = 0;
                        sequence.Clear();
                        sequence.Append($"{regions[++nRegionIndex]} {letters[nLettersIndex]} {nextNumbers}");
                    }
                    else
                    {
                        nextNumbers = 1;
                        sequence.Clear();
                        sequence.Append($"{regions[nRegionIndex]} {letters[++nLettersIndex]} {nextNumbers}");
                    }
                }
                else
                {
                    sequence.Clear();
                    sequence.Append($"{regions[nRegionIndex]} {letters[nLettersIndex]} {++nextNumbers}");
                }
            } while (carNumbers.Contains(sequence.ToString()));
            numbers = nextNumbers;
            lettersIndex = nLettersIndex;
            regionIndex = nRegionIndex;
            carNumbers.Add(sequence.ToString());
            return sequence.ToString();
        }
        public string CreateNextNumber(string region)
        {
            ushort nextNumbers, nLettersIndex, nRegionIndex;
            try
            {
                nRegionIndex = (ushort)Array.IndexOf(regions, region);
            }
            catch
            {
                return null;
            }
            if (nRegionIndex > regionIndex)
            {
                nextNumbers = 0;
                nLettersIndex = 0;
            }
            else if (nRegionIndex < regionIndex) return null;
            else
            {
                nextNumbers = numbers;
                nLettersIndex = lettersIndex;
            }
            do
            {
                if (nextNumbers == 9999 || nextNumbers == 999 && sequence.Length == 10)
                {
                    if (nLettersIndex == letters.Count - 1) return null;
                    nextNumbers = 1;
                    sequence.Clear();
                    sequence.Append($"{regions[nRegionIndex]} {letters[++nLettersIndex]} {nextNumbers}");
                }
                else
                {
                    sequence.Clear();
                    sequence.Append($"{regions[nRegionIndex]} {letters[nLettersIndex]} {++nextNumbers}");
                }
            } while (carNumbers.Contains(sequence.ToString()));
            numbers = nextNumbers;
            lettersIndex = nLettersIndex;
            regionIndex = nRegionIndex;
            carNumbers.Add(sequence.ToString());
            return sequence.ToString();
        }
        public string CreatePreviousNumber()
        {
            ushort nextNumbers = numbers, nLettersIndex = lettersIndex, nRegionIndex = regionIndex;
            do
            {
                if (nextNumbers == 1)
                {
                    if (nLettersIndex == 0)
                    {
                        if (nRegionIndex == 0) return null;
                        nLettersIndex = (ushort)(letters.Count - 1);
                        sequence.Clear();
                        sequence.Append($"{regions[--nRegionIndex]} {letters[nLettersIndex]} ");
                        nextNumbers = (ushort)(sequence.Length.Equals(7) ? 999 : 9999);
                        sequence.Append(nextNumbers);
                    }
                    else
                    {
                        sequence.Clear();
                        sequence.Append($"{regions[nRegionIndex]} {letters[--nLettersIndex]} ");
                        nextNumbers = (ushort)(sequence.Length.Equals(7) ? 999 : 9999);
                        sequence.Append(nextNumbers);
                    }
                }
                else
                {
                    sequence.Clear();
                    sequence.Append($"{regions[nRegionIndex]} {letters[nLettersIndex]} {--nextNumbers}");
                }
            } while (carNumbers.Contains(sequence.ToString()));
            numbers = nextNumbers;
            lettersIndex = nLettersIndex;
            regionIndex = nRegionIndex;
            carNumbers.Add(sequence.ToString());
            return sequence.ToString();
        }
        public string CreatePreviousNumber(string region)
        {
            ushort nextNumbers, nLettersIndex, nRegionIndex;
            try
            {
                nRegionIndex = (ushort)Array.IndexOf(regions, region);
            }
            catch
            {
                return null;
            }
            if (nRegionIndex < regionIndex)
            {
                nLettersIndex = (ushort)(letters.Count - 1);
                sequence.Clear();
                sequence.Append($"{regions[nRegionIndex]} {letters[nLettersIndex]} ");
                nextNumbers = (ushort)(sequence.Length.Equals(7) ? 1000 : 10000);
            }
            else if (nRegionIndex > regionIndex) return null;
            else
            {
                nextNumbers = numbers;
                nLettersIndex = lettersIndex;
            }
            do
            {
                if (nextNumbers == 1)
                {
                    if (nLettersIndex == 0) return null;
                    sequence.Clear();
                    sequence.Append($"{regions[nRegionIndex]} {letters[--nLettersIndex]} ");
                    nextNumbers = (ushort)(sequence.Length.Equals(7) ? 999 : 9999);
                    sequence.Append(nextNumbers);
                    
                }
                else
                {
                    sequence.Clear();
                    sequence.Append($"{regions[nRegionIndex]} {letters[nLettersIndex]} {--nextNumbers}");
                }
            } while (carNumbers.Contains(sequence.ToString()));
            numbers = nextNumbers;
            lettersIndex = nLettersIndex;
            regionIndex = nRegionIndex;
            carNumbers.Add(sequence.ToString());
            return sequence.ToString();
        }
        public List<string> GetCarNumbers()
        {
            return carNumbers;
        }
    }
}