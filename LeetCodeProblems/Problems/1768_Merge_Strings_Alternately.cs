using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems._1768;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var builder = new StringBuilder();
        for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
        {
            if (i < word1.Length)
            {
                if (word1[i] != ' ')
                {
                    builder.Append(word1[i]);
                }
                else
                {
                    builder.Append(' ');
                }
            }
            if (i < word2.Length)
            {
                if (word2[i] != ' ')
                {
                    builder.Append(word2[i]);
                }
                else
                {
                    builder.Append(' ');
                }
            }
        }
        return builder.ToString();
    }
}
