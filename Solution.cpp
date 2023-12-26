
#include <vector>
using namespace std;

class Solution {
    
public:
    vector<vector<int>> findMissingRanges(const vector<int>& input, int lowerLimit, int upperLimit) const {

        vector<vector<int>> allMissingRanges;
        if (input.empty()) {
            allMissingRanges.push_back({lowerLimit, upperLimit});
            return allMissingRanges;
        }

        if (input[0] > lowerLimit) {
            allMissingRanges.push_back({lowerLimit, input[0] - 1});
        }
        for (int i = 1; i < input.size(); ++i) {
            if (input[i - 1] + 1 != input[i]) {
                allMissingRanges.push_back({input[i - 1] + 1, input[i] - 1});
            }
        }
        if (input[input.size() - 1] < upperLimit) {
            allMissingRanges.push_back({input[input.size() - 1] + 1, upperLimit});
        }

        return allMissingRanges;
    }
};
