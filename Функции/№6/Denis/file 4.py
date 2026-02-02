



'''
Напишите функцию  create_info , которая имеет следующие параметры 
    —   employees  содержит имена работников в виде списка  
    —   identifiers  содержит уникальные идентификаторы работников  
Функция  create_info  на основании параметров  employees  и  identifiers  должна создать словарь, 
    ключами которого являются идентификаторы, 
    а значениями - имена сотрудников. 

Соединение идентификатора и имени сотрудника должно выполняться по следующей логике:  
1. Выбирается самый маленький идентификатор из списка  identifiers  
2. Выбирается первое имя по алфавиту из списка  employees  
3. Создается пара ключ-значение. 
4. Процесс повторяется со следующими значениями. Берется второй по 
    старшинству идентификатор и второе имя по алфавиту, создается пара в 
    словаре и вновь повторяем процесс 
Итоговый словарь функция  create_info  должна вернуть в качестве результата.

'''

def create_info(employees: list[str], identifiers: list[int]):
    """Функция  на основании параметров  employees  и  identifiers  должна создать словарь, 
    ключами которого являются идентификаторы, 
    а значениями - имена сотрудников.

    Args:
        employees (list[str]): содержит имена работников
        identifiers (list[int]): содержит уникальные идентификаторы
    """
    names = employees[:]
    names.sort()
    ids = identifiers[:]
    ids.sort()
    
    res = {}
    
    for i in range(len(names)):
        res[ids.pop(0)] = names.pop(0)
        
    return res
    

    
names = [ 
    'Pankratiy', 'Lidochka', 'Svetka', 'Maks', 'Yura', 'Sergei' 
] 
 
ids = [77, 4, 20, 37, 32, 96] 
print(create_info(names, ids))
print()



names = [ 
    'Pankratiy', 'Lidochka', 'Innokentiy', 'Anfisa', 
'Yaroslava', 
    'Svetka', 'Maks', 'Yura', 'Sergei' 
] 
 
ids = [77, 4, 20, 5, 56, 17, 20, 32, 96] 
print(create_info(names, ids))
print()