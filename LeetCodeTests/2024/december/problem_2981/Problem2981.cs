using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace LeetCodeTests
{
    public class Problem2981
    {
        public int MaximumLength(string str)
        {
            int countChars = str.Length;

            var specialSubStringFound = new List<string>();

            int left = 0;
            int right = countChars - 1;
            int biggestString = -1;

            while (left <= right && right > 0)
            {
                bool foundBestSolution = false;
                int newBiggestString = -1;
                int sizeSubString = left + (right - left) / 2;
                sizeSubString = sizeSubString <= 0 ? 1 : sizeSubString;
                for (int i = 0; i < 1 + countChars - sizeSubString; i++)
                {
                    string subStr = str.Substring(i, sizeSubString);
                    if (IsSpecialString(subStr))
                    {
                        specialSubStringFound.Add(subStr);
                        if (specialSubStringFound.Count(x => x == subStr) > 2)
                        {
                            foundBestSolution = true;
                            newBiggestString = subStr.Length;
                            break;
                        }
                    }
                }
                if (newBiggestString > biggestString)
                {
                    biggestString = newBiggestString;
                }
                if (foundBestSolution)
                {
                    left = sizeSubString + 1;
                }
                else
                {
                    right = sizeSubString - 1;
                }
            }

            return biggestString;
        }

        static bool IsSpecialString(string str)
        {
            if (string.IsNullOrEmpty(str)) return false;

            char firstChar = str[0];

            return str.Count(s => s == firstChar) == str.Length;
        }
    }
}