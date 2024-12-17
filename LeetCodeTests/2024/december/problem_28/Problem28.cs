namespace LeetCodeTests._2024.december.problem_1
{
    internal class Problem28

    {
        public int StrStr(string haystack, string needle)
        {
            int maxSize = haystack.Length - needle.Length + 1;
            for (int i = 0; i < maxSize; i++)
            {
                int count = 0;
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
                if (count == needle.Length)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
