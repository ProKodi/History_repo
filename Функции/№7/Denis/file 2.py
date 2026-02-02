



def summa(N: int):
    if(N <= 1):
        return 1
    return N + summa(N - 1)



print(summa(4))
print()
    
    
print(summa(10))
print()
    
    
print(summa(34))
print()