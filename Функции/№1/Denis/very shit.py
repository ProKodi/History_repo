



from math import isqrt


# Функция проверки простоты числа
def is_prime(n: int) -> bool:
    return n > 1 and all(n % d != 0 for d in range(2, isqrt(n) + 1))

convert = lambda number_str: int(number_str)

is_prime = lambda n: n > 1 and all(n % d != 0 for d in range(2, isqrt(n) + 1))

def main():
    flag = False;

    for i in range(int(input("Введите количество элементов: "))):
        res = is_prime(convert(input("Введите элемент: ")))
        if(not flag): flag = res

    if(flag):
        print("Содержит простое число")
    else:
        print("Не содержит простых чисел")


if __name__ == "__main__":
    main()