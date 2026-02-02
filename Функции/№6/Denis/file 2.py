



'''
Напишите функцию  filter_numbers , 
    которая принимает список целых чисел и возвращает новый список, 
    
    который состоит только из четных чисел входного списка 
    или из тех, которые по модулю больше 100.

'''

def filter_numbers(numbers: list[int]):
    res = []
    for i in numbers:
        if i % 2 == 0:
            res.append(i)
        elif abs(i) > 100:
            res.append(i)
    return res;



numbers = [1, 2, 3, 4, 5, 6, 7] 
print(filter_numbers(numbers)) 
print()


numbers = [-100, 2, -300, -400, 5, -60, -61, -101, 101] 
print(filter_numbers(numbers)) 
print()