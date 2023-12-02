namespace AlgorithmsDataStructuresLearning;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {

        string prefix = strs[0];
        
        for (int i = 1; i < strs.Length; i++)
        {
            int j = 0;
            while (j < prefix.Length && j < strs[i].Length && prefix[j] == strs[i][j])
            {
                j++;
            }
            prefix = prefix.Substring(0, j);
        }

        return prefix;
    }
}