



def is_strings_equal(str1, str2):
    """
    Сравнивает две строки и возвращает 
        True, если они равны, иначе - False.
    """
    if len(str1) != len(str2):
        return False
    
    str1_dict = {}
    str2_dict = {}
    
    for i in str1:
        if(i not in str1_dict):
            str1_dict[i] = 0;
        str1_dict[i] += 1
        
    for i in str2:
        if(i not in str2_dict):
            str2_dict[i] = 0;
        str2_dict[i] += 1
        
    return str1_dict == str2_dict
        


print(is_strings_equal.__call__("123", "123"))

print()

print(is_strings_equal("leto", "etol"))
print(is_strings_equal("1212", "2131"))
print(is_strings_equal("qwerty", "rtyewq"))
print(is_strings_equal("aabc", "bcab"))
print(is_strings_equal("aabcb", "bcaba"))