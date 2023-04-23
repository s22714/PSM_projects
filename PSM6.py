import math
import matplotlib.pyplot as plt
import numpy as np


def better_euler():
    F = []
    Ek = []
    Ep = []
    Ec = []
    T = []

    L = math.pi
    n = 10
    dt = 0.2
    lPow = 40

    dx = L / n

    xi = [0]
    for i in range(n):
        xi.append(xi[i] + dx)

    f = [0]
    for i in range(1, n):
        f.append(math.sin(xi[i]) / 100000)
    f.append(0)

    v = []
    for i in range(n):
        v.append(0)

    a = [0]
    for i in range(1, n):
        a.append((f[i + 1] - 2 * f[i] + f[i - 1]) / pow(dx, 2))
    a.append(0)

    F.append(f)

    ek = 0.0
    for i in v:
        ek += math.pow(i, 2)
    ek = (dx / 2) * ek
    Ek.append(ek)

    ep = 0.0
    for i in range(1, len(f)):
        ep += math.pow(f[i] - f[i - 1], 2)
    ep = 1 / (2 * dx) * ep
    Ep.append(ep)

    Ec.append(ep + ek)

    t = dt
    T.append(t)

    for i in range(1, lPow):

        f_2 = [0]
        for j in range(1, n):
            f_2.append(f[j] + v[j] * (dt / 2))
        f_2.append(0)

        v_2 = [0]
        for j in range(1, n):
            v_2.append(v[j] + a[j] * (dt / 2))
        v_2.append(0)

        a_2 = [0]
        for j in range(1, n):
            a_2.append((f_2[j + 1] - 2 * f_2[j] +
                       f_2[j - 1]) / pow(dx, 2))
        a_2.append(0)

        newf = [0]
        for j in range(1, n):
            newf.append(f[j] + v_2[j] * dt)
        newf.append(0)

        newv = [0]
        for j in range(1, n):
            newv.append(v[j] + a_2[j] * dt)
        newv.append(0)

        newa = [0]
        for j in range(1, n):
            newa.append((newf[j + 1] - 2 * newf[j] +
                        newf[j - 1]) / pow(dx, 2))
        newa.append(0)

        F.append(newf)

        f = newf
        v = newv
        a = newa

        ek = 0.0
        for j in v:
            ek += math.pow(j, 2)
        ek = (dx / 2) * ek
        Ek.append(ek)

        ep = 0.0
        for j in range(1, len(f)):
            ep += math.pow(f[j] - f[j - 1], 2)
        ep = 1 / (2 * dx) * ep
        Ep.append(ep)

        Ec.append(ep + ek)

        t += dt
        T.append(t)

    x = []
    for i in range(n+1):
        x.append(i)
    for i in range(len(F)):
        plt.plot(x, F[i])
    plt.title("string")
    plt.show()

    plt.plot(T, Ek)
    plt.plot(T, Ep)
    plt.plot(T, Ec)
    plt.title("Energies")
    plt.show()


better_euler()
