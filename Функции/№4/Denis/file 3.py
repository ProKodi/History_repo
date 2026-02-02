



"""
Ваша задача — создать функцию  create_matrix , которая имеет следующие 
параметры: 
• необязательный числовой параметр  size  - размер квадратной матрицы, по 
умолчанию принимает значение 3; 
  
• необязательный числовой параметр  up_fill  - значение заполнителя 
элементов, находящихся выше главной диагонали. По умолчанию равен 0; 
  
• необязательный числовой параметр  down_fill  - значение заполнителя 
элементов, находящихся ниже главной диагонали. По умолчанию равен 0. 

Функция  create_matrix  должна возвращать квадратную матрицу размером  size  
х size , на диагонали которой располагаются числа от 1 до  size . Все остальные 
элементы заполнены согласно параметрам  up_fill  и  down_fill . 
Ваша задача написать только определение функции  create_matrix
    
"""


def create_matrix(size: int = 3, up_fill: float = 0, down_fill: float = 0):
    """
    Создает квадратную матрицу размером size x size с заполненными элементами.
    """
    matrix = []
    for x in range(size):
        row = []
        for y in range(size):
            if(y - x < 0): # ниже диагонали
                row.append(down_fill)
            elif(y - x == 0): # диагональ
                row.append(y + 1)
            else: # выше диагонали
                row.append(up_fill)
        matrix.append(row)
            
    return matrix
    
    

print(create_matrix()) 
print(create_matrix(1))
print(create_matrix(size=2))
print(create_matrix(up_fill=7)) 
print(create_matrix(up_fill=7, down_fill=9)) 
