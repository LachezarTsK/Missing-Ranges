
import java.util.ArrayList;
import java.util.List;

public class Solution {

    public List<List<Integer>> findMissingRanges(int[] input, int lowerLimit, int upperLimit) {

        List<List<Integer>> allMissingRanges = new ArrayList<>();
        if (input.length == 0) {
            allMissingRanges.add(List.of(lowerLimit, upperLimit));
            return allMissingRanges;
        }

        if (input[0] > lowerLimit) {
            allMissingRanges.add(List.of(lowerLimit, input[0] - 1));
        }
        for (int i = 1; i < input.length; ++i) {
            if (input[i - 1] + 1 != input[i]) {
                allMissingRanges.add(List.of(input[i - 1] + 1, input[i] - 1));
            }
        }
        if (input[input.length - 1] < upperLimit) {
            allMissingRanges.add(List.of(input[input.length - 1] + 1, upperLimit));
        }

        return allMissingRanges;
    }
}
