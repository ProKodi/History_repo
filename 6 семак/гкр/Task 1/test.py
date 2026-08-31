



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


СДНФ: (
    ( (nA) and  (nB) and (nC) and (nD) ) or
    ( (nA) and  (nB) and (nC) and ( D) ) or
    ( (nA) and  (nB) and ( C) and (nD) ) or
    ( (nA) and  ( B) and (nC) and (nD) ) or
    ( (nA) and  ( B) and (nC) and ( D) ) or
    ( ( A) and  (nB) and ( C) and (nD) ) or
    ( ( A) and  (nB) and ( C) and ( D) ) or
    ( ( A) and  ( B) and (nC) and (nD) )
)


СДНФ упрощеная: (
    ( (nA) and (nB) and (nD) ) or
    ( (nA) and (nC) ) or
    ( ( A) and (nB) and ( C) ) or
    ( ( B) and (nC) and (nD) )
)

СКНФ: (
    ( ( A) or ( B) or (nC) or (nD) ) and
    ( ( A) or (nB) or (nC) or ( D) ) and
    ( ( A) or (nB) or (nC) or (nD) ) and
    ( (nA) or ( B) or ( C) or ( D) ) and
    ( (nA) or ( B) or ( C) or (nD) ) and
    ( (nA) or (nB) or ( C) or (nD) ) and
    ( (nA) or (nB) or (nC) or ( D) ) and
    ( (nA) or (nB) or (nC) or (nD) )
)

СКНФ упрощеная: (
    ( (nA) and (nB) and (nD) ) or
    ( (nA) and (nC) ) or
    ( ( A) and (nB) and ( C) ) or
    ( ( B) and (nC) and (nD) )
)



'''



correct_res = [ 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 ]


def DeConFun(A: bool, B: bool, C: bool, D: bool):
    """ СДНФ """
    nA = not A
    nB = not B
    nC = not C
    nD = not D  

    return (
        ( (nA) and  (nB) and (nC) and (nD) ) or
        ( (nA) and  (nB) and (nC) and ( D) ) or
        ( (nA) and  (nB) and ( C) and (nD) ) or
        ( (nA) and  ( B) and (nC) and (nD) ) or
        ( (nA) and  ( B) and (nC) and ( D) ) or
        ( ( A) and  (nB) and ( C) and (nD) ) or
        ( ( A) and  (nB) and ( C) and ( D) ) or
        ( ( A) and  ( B) and (nC) and (nD) )
    )



def DeConFunEasy(A: bool, B: bool, C: bool, D: bool):
    """ СДНФ упрощеная """
    nA = not A
    nB = not B
    nC = not C
    nD = not D  

    return  (
        ( (nA) and (nB) and (nD) ) or
        ( (nA) and (nC) ) or
        ( ( A) and (nB) and ( C) ) or
        ( ( B) and (nC) and (nD))
    )



def ConFun(A: bool, B: bool, C: bool, D: bool):
    """ СКНФ """
    nA = not A
    nB = not B
    nC = not C
    nD = not D  

    return (
        ( ( A) or ( B) or (nC) or (nD) ) and
        ( ( A) or (nB) or (nC) or ( D) ) and
        ( ( A) or (nB) or (nC) or (nD) ) and
        ( (nA) or ( B) or ( C) or ( D) ) and
        ( (nA) or ( B) or ( C) or (nD) ) and
        ( (nA) or (nB) or ( C) or (nD) ) and
        ( (nA) or (nB) or (nC) or ( D) ) and
        ( (nA) or (nB) or (nC) or (nD) )
    )


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




DeConFun_test = []
DeConFunEasy_test = []

ConFun_test = []
ConFunEasy_test = []



for A in [False, True]:
    for B in [False, True]:
        for C in [False, True]:
            for D in [False, True]:
                DeConFun_test.append(int(DeConFun(A, B, C, D)))

                DeConFunEasy_test.append(int(DeConFunEasy(A, B, C, D)))

                ConFun_test.append(int(ConFun(A, B, C, D)))

                ConFunEasy_test.append(int(ConFunEasy(A, B, C, D)))


print(correct_res == DeConFun_test) # True
print(correct_res == DeConFunEasy_test) # True


print(correct_res == ConFun_test) # True
print(correct_res == ConFunEasy_test) # True
