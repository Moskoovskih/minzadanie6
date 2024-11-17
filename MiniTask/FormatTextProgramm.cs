using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTask
{
    class FormatTextProgramm
    {
        public static bool CanFormat(int K, string line)
        {
            return line.Length <= K;
        }
        public static string FormatLine(int K, string line)
        {
            if (!CanFormat(K, line))
            {
                return string.Empty; 
            }

            int totalSpaces = K - line.Length;
            int leadingSpaces = totalSpaces / 2;
            int trailingSpaces = totalSpaces - leadingSpaces;

            return new string(' ', leadingSpaces) + line + new string(' ', trailingSpaces);
        }

        
    }
}
