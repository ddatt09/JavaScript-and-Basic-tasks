/*
 
  I was tasked with buying n liters of water.I buy only a 0.5 liter bottle, b a 1 liter bottle and c a 2 liter bottle.

I was curious how many ways to buy n liters of water from these bottles. Write a function that determines the number of ways to help me. Two ways are said to be different if they differ in the number of bottles purchased for at least one type.

For example

For n = 10, a = 5, b = 5, c = 5, the result will be numberOfWays (n, a, b, c) = 9.
For n = 3, a = 0, b = 0, c = 2, the result will be numberOfWays (n, a, b, c) = 0.
  
 */

let n = 999,
  a = 999,
  b = 899,
  c = 299;

function numberOfWays(n, a, b, c) {
    let result = 0;
    loop1: for (let i = 0; i <= a; i++) {
        loop2: for (let j = 0; j <= b; j++) {
            if (j + 0.5 * i == n) {
                result += 1;
                break loop2;
            } else {
                loop3: for (let k = 0; k <= c; k++) {
                    if (2 * k + 0.5 * i + j == n) {
                        result += 1;
                        break loop3;
                    }
                }
            }
        }
    }
    return result;
}

console.log(numberOfWays(n, a, b, c));
