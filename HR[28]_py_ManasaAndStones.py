"""
................................................. Manasa and Stones ...............................................

TASK LINK: https://www.hackerrank.com/challenges/manasa-and-stones/problem

"""


def stones(n, a, b):
    result = []

    for i in range(n):
        result.append(a * (n - 1 - i) + b * i)
        if a == b: break

    return sorted(result)


if __name__ == '__main__':
    T = int(input())

    for T_itr in range(T):
        n = int(input())

        a = int(input())

        b = int(input())

        result = stones(n, a, b)

        print(' '.join(map(str, result)))
        print('\n')
