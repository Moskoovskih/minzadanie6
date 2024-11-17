using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTask
{
    class Program
    {
        static void Main()
        {
            string[] input = File.ReadAllLines("INPUT.TXT");
            string[] firstLine = input[0].Split();
            int K = int.Parse(firstLine[0]);
            int N = int.Parse(firstLine[1]);

            string[] lines = new string[N];
            for (int i = 1; i <= N; i++)
            {
                lines[i - 1] = input[i];
            }

            var result = FormatLetter(K, N, lines);
            File.WriteAllLines("OUTPUT.TXT", result);
        }

        static string[] FormatLetter(int K, int N, string[] lines)
        {
            string[] formattedLines = new string[N];

            for (int i = 0; i < N; i++)
            {
                string line = lines[i];
                int length = line.Length;
                if (length > K)
                {
                    return new string[] { "Impossible." };
                }
                
                int spaceNeeded = K - length;
                int leadingSpaces = spaceNeeded / 2;
                int trailingSpaces = spaceNeeded - leadingSpaces;

                formattedLines[i] = new string(' ', leadingSpaces) + line + new string(' ', trailingSpaces);
            }

            return formattedLines;
        }
    }
}
