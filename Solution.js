
/**
 * @param {number[]} input
 * @param {number} lowerLimit
 * @param {number} upperLimit
 * @return {number[][]}
 */
var findMissingRanges = function (input, lowerLimit, upperLimit) {

    const allMissingRanges = new Array();
    if (input.length === 0) {
        allMissingRanges.push([lowerLimit, upperLimit]);
        return allMissingRanges;
    }

    if (input[0] > lowerLimit) {
        allMissingRanges.push([lowerLimit, input[0] - 1]);
    }
    for (let i = 1; i < input.length; ++i) {
        if (input[i - 1] + 1 !== input[i]) {
            allMissingRanges.push([input[i - 1] + 1, input[i] - 1]);
        }
    }
    if (input[input.length - 1] < upperLimit) {
        allMissingRanges.push([input[input.length - 1] + 1, upperLimit]);
    }

    return allMissingRanges;
};
