using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class LargestNumber
    {
        public static string largestNumber(List<int> A)
        {
            var temp1 = "999819479319089079038998758718418328218137775172271870869667672667652638633619594587587576574496491485475386339303331281263237224193102";
            var temp2 = "999819479319089079038998758718418328218137775172271870869667672667652638633619594587587576574496491485475386339331303281263237224193102";
            var l = A.Select(e => e.ToString()).ToList();
            l.Sort(
                (string st1, string st2) =>
                {
                    if (st1.StartsWith(st2, StringComparison.Ordinal))
                        st1 = st1.Substring(st2.Length);
                    else if (st2.StartsWith(st1, StringComparison.Ordinal))
                        st2 = st2.Substring(st1.Length);

                    return string.Compare(st2, st1);
                 });
            var result = string.Join("", l.ToArray()).TrimStart(new Char[] { '0' });
            return string.IsNullOrEmpty(result) ? "0" : result;

        }

    }
}
