
using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> FindMissingRanges(int[] input, int lowerLimit, int upperLimit)
    {
        IList<IList<int>> allMissingRanges = new List<IList<int>>();
        if (input.Length == 0)
        {
            allMissingRanges.Add(new List<int>() { lowerLimit, upperLimit });
            return allMissingRanges;
        }

        if (input[0] > lowerLimit)
        {
            allMissingRanges.Add(new List<int>() { lowerLimit, input[0] - 1 });
        }
        for (int i = 1; i < input.Length; ++i)
        {
            if (input[i - 1] + 1 != input[i])
            {
                allMissingRanges.Add(new List<int>() { input[i - 1] + 1, input[i] - 1 });
            }
        }
        if (input[input.Length - 1] < upperLimit)
        {
            allMissingRanges.Add(new List<int>() { input[input.Length - 1] + 1, upperLimit });
        }

        return allMissingRanges;
    }
}
