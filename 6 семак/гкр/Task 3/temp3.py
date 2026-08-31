



"""
Fun: (

)




"""



def Fun(A: bool, B: bool, C: bool, D: bool) -> bool:
    r1 = D or A

    r2 = not (C and B)

    r3 = r1 ^ r2

    return r3 and D



def FunEasy(A: bool, B: bool, C: bool, D: bool) -> bool:
    return C and B and D






print("A	B	C	D	F")


for A in [False, True]:
    for B in [False, True]:
        for C in [False, True]:
            for D in [False, True]:
                print(f"{int(A)}	{int(B)}	{int(C)}	{int(D)}	{int(Fun(A, B, C, D))}")



temp1 = []
temp2 = []

for A in [False, True]:
    for B in [False, True]:
        for C in [False, True]:
            for D in [False, True]:
                temp1.append(Fun(A, B, C, D))
                temp2.append(FunEasy(A, B, C, D))
                

print(temp1 == temp2)