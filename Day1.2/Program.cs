using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> leftValuesList = new List<int>();
            List<int> rightValuesList = new List<int>();
            List<int> totalSimilarityScoresList = new List<int>();

            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string filePath = Path.Combine(currentDirectory, "input.txt");
                StreamReader sr = new StreamReader(filePath);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(new string[] { "   " }, StringSplitOptions.None);
                    if (parts.Length == 2 && int.TryParse(parts[0], out int leftValue) && int.TryParse(parts[1], out int rightValue))
                    {
                        leftValuesList.Add(leftValue);
                        rightValuesList.Add(rightValue);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid line format: {line}");
                    }
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            while (leftValuesList.Count > 0)
            {
                int leftElement = leftValuesList.First();
                int nrRecurences = rightValuesList.Count(x => x == leftElement);

                if (nrRecurences > 0)
                {
                    Console.WriteLine($"Recurence found: {leftElement} appeared {nrRecurences} times");
                    int similarityScore = nrRecurences * leftElement;
                    totalSimilarityScoresList.Add(similarityScore);
                }
                else
                {
                    Console.WriteLine($"{leftElement} showed up {nrRecurences} number of times");
                }

                leftValuesList.Remove(leftElement);
            }
            int totalSimilarityScores = totalSimilarityScoresList.Sum();
            Console.WriteLine("Total similarity score: " + totalSimilarityScores);
        }
    }
}