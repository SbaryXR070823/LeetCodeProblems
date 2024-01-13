using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems._242;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> sMap = new Dictionary<char, int>();
        Dictionary<char, int> tMap = new Dictionary<char, int>();
        for (int i=0; i<s.Length; i++)
        {
            if (sMap.ContainsKey(s[i]))
            {
                sMap[s[i]]++;
            }else
            {
                sMap.Add(s[i], 1);
            }

            if (tMap.ContainsKey(t[i]))
            {
                tMap[t[i]]++;
            }
            else
            {
                tMap.Add(t[i], 1);
            }
        }

        foreach (var kvp in sMap)
        {
            if (tMap.ContainsKey(kvp.Key))
            {
                if (tMap[kvp.Key] != kvp.Value)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
