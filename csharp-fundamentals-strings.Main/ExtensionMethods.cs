using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_strings.Main
{
    public static class ExtensionMethods
    {
        public static string ReverseMe(this string str)
        {
            return new string(str.Reverse().ToArray());
        }
    }
}
