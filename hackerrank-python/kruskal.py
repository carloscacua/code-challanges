#search find union


def find(x, uf):
    if uf[x] == x:
        return x
    else:
        uf[x] = find(uf[x], uf)
        return uf[x]


def union(x, y, uf):
    uf[find(x, uf)] = find(y, uf)


def kruskals(g_nodes, g_from, g_to, g_weight):
    uf = list(range(g_nodes + 1))
    sum = 0
    sorted_e = sorted(zip(g_weight, g_from, g_to))
    for w, u, v in sorted_e:
        if find(u, uf) == find(v, uf):
            continue
        union(u, v, uf)
        sum += w
    return sum


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    g_nodes, g_edges = map(int, input().rstrip().split())

    g_from = [0] * g_edges
    g_to = [0] * g_edges
    g_weight = [0] * g_edges

    for i in range(g_edges):
        g_from[i], g_to[i], g_weight[i] = map(int, input().rstrip().split())

    res = kruskals(g_nodes, g_from, g_to, g_weight)

    fptr.write(str(res))
    # Write your code here.

    fptr.close()
