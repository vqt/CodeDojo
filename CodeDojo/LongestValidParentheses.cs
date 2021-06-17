using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDojo
{
    public partial class Solution
    {
        public int LongestValidParentheses(string s)
        {
            var valid = new bool[s.Length];
            var indices = new Stack<int>();
            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (c == '(')
                {
                    indices.Push(i);
                }
                else if (c == ')' && indices.Any())
                {
                    valid[i] = true;
                    valid[indices.Pop()] = true;
                }
            }
            return Longest(valid);
            int Longest(bool[] valid)
            {
                var max = 0;
                var len = 0;
                foreach (var v in valid) max = Math.Max(max, len = v ? len + 1 : 0);
                return max;
            }
        }
    }
}
