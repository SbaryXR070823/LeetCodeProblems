using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems._28;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int index = haystack.IndexOf(needle);

        if (index != -1)
        {
            return index;
        }
        else
        {
            return -1;
        }
    }
}
