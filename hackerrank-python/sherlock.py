from collections import Counter

def isValid(s):
    r = True
    d = Counter(s)
    c = Counter(d)
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
