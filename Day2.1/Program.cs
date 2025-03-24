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
            // Testing logic to find safe reports, idea is to find the nr of unsafe reports,
            // subtract the total nr of reports with the nr of unsafe reports and the sum will be the nr of safe reports

            int[] testInputs = { 73, 75, 78, 81, 80 };
            int nrUnsafeReports = 0;
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
                    nrUnsafeReports++;
                    Console.WriteLine();
                    Console.WriteLine("Unsafe");
                    break;
                }
            }
        }
    }
}
