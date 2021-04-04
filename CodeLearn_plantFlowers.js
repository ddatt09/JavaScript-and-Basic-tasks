/*
  Given a flower garden corresponding to array arr consisting of the numbers 0, 1. The position that has the number 1 will represent the land used to plant flowers. And the number 0 represents vacant land. You currently have n flowers. Calculate whether n flowers can be planted on that land, so that the positions next to them do not have any flowers.

For example:

For arr = [1, 0, 0, 0, 1], n = 1. The output plantFlowers (arr) = true.
      Explanation: We can plant a flower at position 2 (starting position is position 0)

For arr = [1, 0, 0, 0, 1], n = 2. PlantFlowers (arr) = false output. 
 */

function plantFlowers(arr, n) {
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] == 0) {
            if (arr[i + 1] != 1 && arr[i - 1] != 1) {
                arr[i] = 1;
                n -= 1;
            }
        }
        if (n == 0) return true;
    }
    return false;
}

console.log(plantFlowers(arr, n));
