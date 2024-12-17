using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace LeetCodeTests
{
    public class Problem2054
    {
        public static int Run(int[][] events)
        {
            var bestPossibleSum = 0;

            for (int i = 0; i < events.Length; i++)
            {
                for (int j = i; j < events.Length; j++)
                {
                    int bestValueIteration = events[j][2];
                    if (!HasOverlap(events[i], events[j]))
                        bestValueIteration = events[i][2] + events[j][2];

                    if (bestValueIteration > bestPossibleSum)
                        bestPossibleSum = bestValueIteration;
                }
            }

            return bestPossibleSum;
        }

        static bool HasOverlap(int[] set1, int[] set2)
        {
            var sizeSet1 = set1[1] - set1[0];
            var sizeSet2 = set2[1] - set2[0];

            if (sizeSet1 >= sizeSet2)
            {
                int left = set1[0];
                int right = set1[1];
                if (FoundBinarySearch(left, right, set2[0])
                    || FoundBinarySearch(left, right, set2[1]))
                    return true;
            }
            else
            {
                int left = set2[0];
                int right = set2[1];
                if (FoundBinarySearch(left, right, set1[0])
                     || FoundBinarySearch(left, right, set1[1]))
                    return true;
            }

            return false;
        }

        static bool FoundBinarySearch(int left, int right, int searchingElement)
        {
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (mid == searchingElement || left == searchingElement || right == searchingElement)
                    return true;

                if (searchingElement < mid)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return false;
        }
    }
}