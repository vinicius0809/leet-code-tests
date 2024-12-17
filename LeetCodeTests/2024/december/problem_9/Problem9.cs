namespace LeetCodeTests._2024.december.problem_1
{
    internal class Problem9
    {
        public bool IsPalindrome(int x)
        {
            string strX = x.ToString();
            return IsPalindrome(strX, 0, strX.Length - 1);
        }

        public bool IsPalindrome(string str, int i1, int i2)
        {
            if (i1 >= i2)
                return true;

            if (str[i1] != str[i2])
                return false;

            return IsPalindrome(str, i1 + 1, i2 - 1);
        }
    }
}
