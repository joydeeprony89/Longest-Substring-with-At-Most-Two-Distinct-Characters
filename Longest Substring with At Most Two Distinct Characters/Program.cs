using System;

namespace Longest_Substring_with_At_Most_Two_Distinct_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ecebaaabbb"; // ccaabbb
            Console.WriteLine(LengthOfLongestSubstringTwoDistinct(s));
        }

        static int LengthOfLongestSubstringTwoDistinct(string s)
        {
            int[] hash = new int[128];
            int left = 0, right = 0, counter = 0, max = 0;

            for (; right < s.Length; right++)
            {
                char rightc = s[right];
                if (hash[rightc] == 0) counter++;
                hash[rightc]++;
                if(counter > 2)
                {
                    char leftc = s[left];
                    hash[leftc]--;
                    if (hash[leftc] == 0) counter--;
                    left++;
                }
                max = Math.Max(max, right - left + 1);
            }

            return max;
        }
    }
}
