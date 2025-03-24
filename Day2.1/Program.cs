using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Testing logic to find safe reports
            int[] testInputs = { 73, 75, 78, 81, 80 };
            int nrSafeReports = 0;
            bool isUnsafe = false;

                for (int i = 0; i < testInputs.Length - 1; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Current element: " + i);

                    if (Math.Abs(testInputs[i] - testInputs[i + 1]) <= 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Safe");
                    }
                    else
                    {
                        isUnsafe = true;
                        Console.WriteLine();
                        Console.WriteLine("Unsafe");
                        break;

                    }

                    if (!isUnsafe)
                    {
                        nrSafeReports++;
                    }
                }
        }
    }
}
