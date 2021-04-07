"""

"""
# Complete the countApplesAndOranges function below.
def countApplesAndOranges(s, t, a, b, apples, oranges):
    fallApplePositions = [e+a for e in apples]
    fallOrangePositions  = [e+b for e in oranges]
    
    appleNum = sum(1 for e in fallApplePositions if e >=s and e <=t)
    orangeNum = sum(1 for e in fallOrangePositions if e >=s and e <=t)
    
    print(f"{appleNum}\n{orangeNum}")

if __name__ == '__main__':
    st = input().split()

    s = int(st[0])

    t = int(st[1])

    ab = input().split()

    a = int(ab[0])

    b = int(ab[1])

    mn = input().split()

    m = int(mn[0])

    n = int(mn[1])

    apples = list(map(int, input().rstrip().split()))

    oranges = list(map(int, input().rstrip().split()))

    countApplesAndOranges(s, t, a, b, apples, oranges)
