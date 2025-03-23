using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DayOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> leftValuesList = new List<int>();
            List<int> rightValuesList = new List<int>();
            List<int> totalDistancesList = new List<int>();

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

            while (leftValuesList.Count > 0 && rightValuesList.Count > 0)
            {
                int leftMin = leftValuesList.Min();
                int rightMin = rightValuesList.Min();

                int distance = Math.Abs(leftMin - rightMin);
                totalDistancesList.Add(distance);

                leftValuesList.Remove(leftMin);
                rightValuesList.Remove(rightMin);

                Console.WriteLine($"Left Min: {leftMin}, Right Min: {rightMin}, Distance: {distance}");
            }

            int totalDistance = totalDistancesList.Sum();
            Console.WriteLine($"Total distance: {totalDistance}");
        }
    }
}