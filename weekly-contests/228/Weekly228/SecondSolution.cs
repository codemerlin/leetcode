using System;

namespace Weekly228.Second
{
    public class Solution
    {
        public int CountHomogenous(string s)
        {
            var lastChar = s[0];
            var count = 0;
            var result = 0;
            foreach (var c in s)
            {
                if (lastChar != c)
                {
                    result += FindSum(count);
                    count = 1;
                    lastChar = c;
                }
                else
                {
                    count++;
                }
            }
            result += FindSum(count);
            return result;
        }

        private int FindSum(int startWith)
        {
            var sum = 0;
            var mod = 1000000007;

            while (startWith > 0)
            {
                sum += startWith % mod;
                startWith--;
                
            }
            return sum;
        }

    }
}
