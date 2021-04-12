"""
.................................................Bill Division ...............................................

LINK ORIGIN: https://www.hackerrank.com/challenges/bon-appetit/problem

"""
def bonAppetit(bill, k, b):
    sumShare = sum(bill) - bill[k]
    annaPays = sumShare // 2
    if b == annaPays:
        print('Bon Appetit')
        return

    brianRest = abs(b - annaPays)
    print(brianRest)
    
    if __name__ == '__main__':
    nk = input().rstrip().split()

    n = int(nk[0])

    k = int(nk[1])

    bill = list(map(int, input().rstrip().split()))

    b = int(input().strip())

    bonAppetit(bill, k, b)
