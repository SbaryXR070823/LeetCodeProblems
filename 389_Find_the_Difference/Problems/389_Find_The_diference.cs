using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems._389;

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        char[] charArray = t.ToCharArray();
        Array.Sort(charArray);
        string sortedTString = new string(charArray);
        if (string.IsNullOrEmpty(s))
        {
            return t[0];
        }
        else
        {
            charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sortedSString = new string(charArray);
            int minLength = Math.Min(sortedTString.Length, sortedSString.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (sortedSString[i] != sortedTString[i])
                {
                    return sortedTString[i];
                }
            }

            return sortedTString.Length > minLength ? sortedTString[minLength] : '\0';
        }
    }
}
