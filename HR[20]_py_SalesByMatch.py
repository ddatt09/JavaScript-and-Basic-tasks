"""
................................................. Sales by Match ...............................................

LINK ORIGIN: https://www.hackerrank.com/challenges/sock-merchant/problem

"""

# Complete the sockMerchant function below.
def sockMerchant(n, ar):
    arrSock = []
    sockNum = 0
    for i in range(len(ar)):
        if ar[i] not in arrSock:
            arrSock.append(ar[i])
            sockNum += ar.count(ar[i]) // 2

    return sockNum


if __name__ == '__main__':
    n = int(input())

    ar = list(map(int, input().rstrip().split()))

    result = sockMerchant(n, ar)

    print(str(result) + '\n')
