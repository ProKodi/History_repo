



'''
Перед вами два списка одинаковой длины  keys  и  values  
Ваша задача — создать словарь, в котором пара  ключ-значение  берется из 
значений списков, стоящих на одинаковых индексах. 
В качестве ответа выведите полученный словарь
'''

keys = ['Ten', 'Twenty', 'Thirty', 'Forty', 'Fifty', 'Sixty', 
    'Seventy', 'Eighty', 'Ninety', 'One hundred'
] 
values = [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]


def function():
    res = {}
    for i in range(len(keys)):
        res[keys[i]] = values[i]
    
    print(res)
    
    
function()