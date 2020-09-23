def sockMerchant(n, ar):
    s = [0 for i in range(101)]
    for x in ar:
        s[x] += 1
    return sum(int(i/2) for i in s)