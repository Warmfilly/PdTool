using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    internal static class Util
    {
        //Used to ensure the Send, Receive, and Label properties of some PD objects have values that are considered valid by PD
        //spaces replaced by underscores, etc.
        internal static string SanitizeSRL(string s)
        {
            s = s.Trim();
            return String.IsNullOrWhiteSpace(s) ? "empty" : s.Replace(' ', '_');
        }

        internal static T[] SubArray<T>(T[] src, int start, int end)
        {
            int length = end - start + 1;

            T[] sub = new T[length];
            System.Array.Copy(src, start, sub, 0, length);
            return sub;
        }
    }
}
