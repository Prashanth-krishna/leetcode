using System;

class Solution
{
    public static string MinWindow(string s1, string s2)
    {
        string minSubSequence = "";

        int indexs1 = 0;
        int indexs2 = 0;

        int s1Length = s1.Length;
        int s2Length = s2.Length;

        int start,
            end = 0;
        float length = float.PositiveInfinity;

        while (indexs1 < s1Length)
        {
            if (s1[indexs1] == s2[indexs2])
            {
                indexs2 += 1;

                // backtrack so that repeated characters in s1 are handled correctly ex: s1 = "sssaz", s2 = "saz"
                if (indexs2 == s2Length)
                {
                    start = indexs1;
                    end = indexs1;
                    indexs2 -= 1;

                    while (indexs2 >= 0)
                    {
                        if (s1[start] == s2[indexs2])
                        {
                            indexs2 -= 1;
                        }
                        start -= 1;
                    }

                    start += 1;
                    if ((end - start + 1) < length)
                    {
                        length = end - start + 1;
                        minSubSequence = s1.Substring(start, end - start + 1);
                    }
                    indexs1 = start;
                    indexs2 = 0;
                }
            }

            indexs1++;
        }

        return minSubSequence;
    }
}