



'''
Перед вами имеется список словарей  persons . 
Изучите внимательно все элементы списка, у них имеется одинаковый набор ключей. 

Ваша задача на основании списка  persons  отобрать информацию о номерах телефона и сложить их в 
    отдельный список  phones. 
Номера в списке  phones  должны располагаться в том же порядке, 
    в котором расположены их владельцы в списке  persons. 
    
В качестве ответа выведите переменную  phones  
Используйте функцию  map

'''

persons = [ 
    { 
        'birthday': '1983-10-25', 
        'job': 'Field seismologist', 
        'name': 'Andrew Hernandez', 
        'phone': '680-436-8521x3468' 
    }, 
    { 
        'birthday': '1993-10-03', 
        'job': 'Pathologist', 
        'name': 'Paul Harmon', 
        'phone': '602.518.4130' 
    }, 
    { 
        'birthday': '2002-06-11', 
        'job': 'Designer, multimedia', 
        'name': 'Gregory Flores', 
        'phone': '691-498-5303x079' 
    } 
]


def take_numbers(dict_with_number: dict[str, str]): 
    return dict_with_number['phone']


def main():
    phones = map(take_numbers, persons)
    print(list(phones))


if __name__ == "__main__":
    main()