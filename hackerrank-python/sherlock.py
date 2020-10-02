from collections import Counter

def isValid(s):
    r = True
    d = Counter(s)
    c = {}
    for l, r in d.items():
        if r in c:
            c[r] += 1
        else:
            c[r] = 1
    if len(c) > 2:
        r = False
    elif len(c) <= 1:
        r = True
    else:
        k = list(c.keys())
        mink = min(k)
        minv = c[mink]
        maxk = max(k)
        maxv = c[maxk]
        r = (maxk - 1 == mink and maxv == 1) or (mink == minv == 1)
    if r:
        return "YES"
    return "NO"

"""

import sys

fptr = sys.stdout

s = input()

r = int(s)
t = int(r*(r+1)/2)


fptr.write(str(t))


fptr.close()

import sys
from math import sqrt

import sys
from math import sqrt

import sys
from math import sqrt


def isPrime(num):
    if num > 1:
        s = int(sqrt(num)) + 1
        for i in range(2, s):
            if (num % i) == 0:
                return False

        return True
    return False


fptr = sys.stdout

n = input()

r = int(n)

for i in reversed(range(r + 1)):
    if (isPrime(i)):
        fptr.write(str(i))
        break

fptr.close()


import sys

lines = [line for line in sys.stdin]
a = [int(i) for i in lines[1].split(" ")]

j = sum = besti = bestj = bestSum = 0

for i in range(len(a)):
    sum += a[i]
    if(sum > bestSum):
        bestSum = sum
        besti = i
        bestj = j
    if(sum < 0):
        j = i+1
        sum = 0

if(bestSum == 0):
    print(max(a))
else:
    print(",".join([str(a[i]) for i in range(bestj, besti+1)]))




import sys

lines = [line for line in sys.stdin]
a = [int(i) for i in lines[0].split(" ")]

print(a[0] ^ a[1])

import sys


def compute_hcf(x, y):
    while (y):
        x, y = y, x % y
    return x


lines = [line for line in sys.stdin]

for line in lines[1:]:
    a = line.strip().split(" ")
    print(compute_hcf(int(a), int(b)))

# !/bin/python3

import math
import os
import random
import re
import sys


# Complete the migratoryBirds function below.
def migratoryBirds(arr):
    a = [0, 0, 0, 0, 0]
    for i in arr:
        a[i - 1] += 1
    m = max(a)
    return -max([e, -i for i, e in enumerate(a)])[1] + 1
    for i in range(5):
        if a[i] == m:
            return i + 1;



# Complete the migratoryBirds function below.
def migratoryBirds(arr):
    a = [0,0,0,0,0]
    for i in arr:
        a[i-1]+=1
    m = max(a)
    return -max([(e,-i) for i,e in enumerate(a)])[1]+1
    for i in range(5):
        if a[i] == m:
            return i+1;

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    arr_count = int(input().strip())

    arr = list(map(int, input().rstrip().split()))

    result = migratoryBirds(arr)

    fptr.write(str(result) + '\n')

    fptr.close()

"""