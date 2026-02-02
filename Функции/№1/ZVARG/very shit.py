




'''
def is_prime(n: int) -> list:
    delit = []
    for i in range(2, n):
        if(n % i == 0):
            delit.append(str(i))
    return delit
'''
is_prime = lambda n: [str(i) for i in range(2, n) if(n % i == 0)]

convert = lambda number_str: int(number_str)


def main():
    while True:
        number = convert(input());
        if(number == 0):  break
        
        res = is_prime(number)
        if(len(res) > 0):
            print(f"{number} - {', '.join(res)}")
            
            
main()