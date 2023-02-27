using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DevstreamTestTask.ProblemSolving
{
    public static class ProblemSolving
    {
        public static string ReverseString(this string str)
        {
            string reverseValue = new(str.Select((ss, index) => new { ss, index })
                                         .OrderByDescending(o => o.index)
                                         .Select(s => s.ss)
                                         .ToArray());
            return reverseValue;
        }

        public static bool IsPalindrome(this string str) => str.ToLower().SequenceEqual(str.ToLower().ReverseString());

        public static IEnumerable<int> MissingElements(this int[] arr)
        {
            return Enumerable.Range(arr.Min(), arr.Max() - arr.Min()).Except(arr);
        }
    }
}
