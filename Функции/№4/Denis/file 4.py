



'''
Здесь функция  words_length  является чистой. Ваша задача переписать ее так, 
чтобы она начала изменять входной список: вместо слов должна подставляться его 
длина. В качестве результата новая  words_length  должна вернуть  None

'''


def words_length(words: list[str]): 
    for i in range(len(words)):
        words[i] = len(words[i])

words = ['Hello', 'world!'] 
words_length(words) 
print(words)
print()

words = ['Python', 'is', 'awesome!'] 
words_length(words) 
print(words)
print()

words = ['Python', 'is', 'awesome!'] 
result = words_length(words) 
print(words) 
print(result)
print()

words = ['Python', 'is', 'awesome!'] 
words = words_length(words) 
print(words)
print()