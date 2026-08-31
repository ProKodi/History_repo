



'''
A	B	C	D	F
0	0	0	0	1
0	0	0	1	1
0	0	1	0	1
0	0	1	1	0
0	1	0	0	1
0	1	0	1	1
0	1	1	0	0
0	1	1	1	0
1	0	0	0	0
1	0	0	1	0
1	0	1	0	1
1	0	1	1	1
1	1	0	0	1
1	1	0	1	0
1	1	1	0	0
1	1	1	1	0

nA = not A
nB = not B
nC = not C
nD = not D





Оригинал: (
    ( (nA) and (nB) and (nD) ) or
    ( (nA) and (nC) ) or
    ( ( A) and (nB) and ( C) ) or
    ( ( B) and (nC) and (nD) )
)

И-НЕ: not (
    (not (not (A and B and D) )) and
    (not (not (A and C) )) and
    (not (A and nB and C)) and
    (not (B and (not (C and D))))
)



'''



correct_res = [ 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 ]


def ConFunEasy(A: bool, B: bool, C: bool, D: bool):
    """ СКНФ упрощеная """
    nA = not A
    nB = not B
    nC = not C
    nD = not D  

    return (
        ( (nA) and (nB) and (nD) ) or
        ( (nA) and (nC) ) or
        ( ( A) and (nB) and ( C) ) or
        ( ( B) and (nC) and (nD) )
    )


def ConEasy(A: bool, B: bool, C: bool, D: bool):
    """ И-НЕ """
    nA = not A
    nB = not B
    nC = not C
    nD = not D  

    return not (
        (not ( (nA) and (nB) and (nD) ) ) and
        (not ( (nA) and (nC) )) and
        (not ( ( A) and (nB) and ( C) )) and
        (not ( ( B) and (nC) and (nD) ))
    )


def Con(A: bool, B: bool, C: bool, D: bool):
    """ ИЛИ-НЕ """
    nA = not A
    nB = not B
    nC = not C
    nD = not D  

    return (
        (not ( A or B or D ) ) or
        (not ( A or C )) or

        # (( A or B or D ) ) or
        # (( A or C )) or

        (not ( nA or B or nC )) or
        (not ( nB or C or D ))
    )







print("A	B	C	D	F")


for A in [False, True]:
    for B in [False, True]:
        for C in [False, True]:
            for D in [False, True]:
                print(f"{int(A)}	{int(B)}	{int(C)}	{int(D)}	{int(ConEasy(A, B, C, D))}")





ConFunEasy_test = []

ConEasy_test = []

Con_test = []



for A in [False, True]:
    for B in [False, True]:
        for C in [False, True]:
            for D in [False, True]:
                ConFunEasy_test.append(int(ConFunEasy(A, B, C, D)))

                ConEasy_test.append(int(ConEasy(A, B, C, D)))

                Con_test.append(int(Con(A, B, C, D)))



print(correct_res == ConFunEasy_test) # True
print(correct_res == ConEasy_test) # True
print(correct_res == Con_test) # True