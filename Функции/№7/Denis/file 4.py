



def quick_power(a: float, n: float):
    print(f"State: a={a}, n={n} ")
    if(n == 0):
        return 1

    if(n % 2 == 0):
        return quick_power(a, n /  2) ** 2
        
    if(n % 2 != 0):
        return quick_power(a, n - 1) * a
        
 
   
print(quick_power(3, 4))
print()

print(quick_power(2, 24)) 
print()

print(quick_power(1, 1000))
print()