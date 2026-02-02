



COUT_LETTERS: int = 26


def is_pangram(string: str):
    res_set = set()
    for i in string.upper():
        unicode_number = ord(i)
        if(unicode_number >= 65 and unicode_number <= 90):
            res_set.add(i)
    
    return len(res_set) == COUT_LETTERS







print(is_pangram("The quick brown fox jumps over the lazy dog."))
print(is_pangram("Obviously not a pangram"))
print(is_pangram("How quickly daft jumping zebras vex!"))

