public class Solution
{
    public IList<string> FindRepeatedDnaSequences(string s)
    {
        Dictionary<string, int> seen = new();
        List<string> result = new();

        for (int i = 0; i <= s.Length - 10; i++)
        {
            string currentString = s.Substring(i, 10);
            if (seen.ContainsKey(currentString))
            {
                if (seen.GetValueOrDefault(currentString) == 1)
                {
                    result.Add(currentString);
                    seen[currentString] += 1;
                }
            }
            else
            {
                seen.Add(currentString, 1);
            }
        }
        return result;

    }
}