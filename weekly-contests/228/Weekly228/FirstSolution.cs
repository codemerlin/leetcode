namespace Weekly228.First
{
    public class Solution
    {
        public int MinOperations(string s)
        {
            var oneOps = 0;
            var zeroOps = 0;
            var zeroStart = '0';
            var oneStart = '1';
            foreach (var c in s)
            {
                if (zeroStart != c)
                {
                    zeroOps++;
                }

                if (oneStart != c)
                {
                    oneOps++;
                }

                var tempStart = zeroStart;
                zeroStart = oneStart;
                oneStart = tempStart;
            }
            return zeroOps < oneOps ? zeroOps : oneOps;
        }
    }

}
