



'''
Напишите функцию  sum_recursive , которая принимает на вход вложенный 
список, конечными элементами которого являются целые числа, и возвращает 
сумму элементов переданного списка. Уровень вложенности списка произвольный. 
Ваша задача только написать определение рекурсивной функции  sum_recursive

'''

def sum_recursive(*args: list[float]) -> float:
    res = 0;
    for i in args:
        if(type(i) != float and type(i) != int):
            res += sum_recursive(*i)
            continue
        res += i
    return res




print(sum_recursive([1, 2, 3, 4, 5]))
print(sum_recursive([[1, 2, 3], [4, 5], [6, 7, 8]]))
print(sum_recursive([1, 2, 3, 4, [[5]], [5]]))