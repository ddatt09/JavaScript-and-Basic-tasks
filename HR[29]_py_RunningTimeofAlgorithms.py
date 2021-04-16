#!/bin/python3
# Task Link : https://www.hackerrank.com/challenges/runningtime/problem
import math
import os
import random
import re
import sys

# Complete the runningTime function below.
def runningTime(arr):
    shift=0
    for slot in range(1, len(arr)): 
        value = arr[slot]
        test_slot = slot - 1
        while test_slot > -1 and arr[test_slot] > value:
            arr[test_slot + 1] = arr[test_slot]
            test_slot = test_slot - 1
            shift+=1
        arr[test_slot + 1] = value
    return shift

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    result = runningTime(arr)

    fptr.write(str(result) + '\n')

    fptr.close()
