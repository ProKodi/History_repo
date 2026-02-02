



def replace(text: str, old: str, new: str = ""):
    # return text.replace(old, new)
    res = text.split(old)
    return new.join(res)
    
    
    
    
    
print(replace('Нет', 'т'))
print(replace('Bella Ciao', 'a'))
print(replace('nobody; i myself farewell analysis', 'l', 'z'))