def isValid(s):
    r = True
    d = {}
    for i in s:
        if i in d:
            d[i] += 1
        else:
            d[i] = 1
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
