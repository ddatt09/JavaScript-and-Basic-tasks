
"""
................................................. Counting Valleys ...............................................

TASK LINK: https://www.hackerrank.com/challenges/counting-valleys/problem

"""


def countingValleys(steps, path):
    compareWithSeaLevel = 0
    numberOfValleys = 0

    for i in range(len(path)):
        if path[i] == "D": compareWithSeaLevel -= 1
        if path[i] == "U": compareWithSeaLevel += 1
        if compareWithSeaLevel == 0 and path[i] == "U": numberOfValleys += 1

    return numberOfValleys


if __name__ == '__main__':
    steps = int(input().strip())

    path = input()

    result = countingValleys(steps, path)

    print(str(result) + '\n')
