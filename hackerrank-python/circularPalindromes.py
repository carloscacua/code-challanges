#Researh: HPM algoritmo
# Complete the circularPalindromes function below.
# aabbaabb
def circularPalindromes(s):
    s2 = s+s
    l = []
    for i in range(len(s)):
        l.append(max_palindrom(s2[i:i+len(s)]))
    return l

def max_palindrom(s):
    m = 0
    for i in range(len(s)):
        for k in range(len(s)):
            if i-k < 0 or i +k >= len(s):
                break
            if s[i+k] == s[i-k]:
                m = max(m, 2*k+1)
            else:
                break

        for k in range(len(s)):
            if i-k < 0 or i+1+k >= len(s):
                break
            if s[i+1+k] == s[i-k]:
                m = max(m, 2*k+2)
            else:
                break
    return m


    #
    # Write your code here.
    #

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    s = input()

    result = circularPalindromes(s)

    fptr.write('\n'.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
