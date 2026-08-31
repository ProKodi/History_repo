



class Letter:
    """ Буква для ноды хафмана """
    def __init__(self, Letter:str, count:int, probl:float):
        """Создание буквы для дерева

        Args:
            Letter (str): Символ буквы
            count (int): Количество букв в слове
            probl (float): Вероятность встречи буквы в слове
        """
        self.Letter = Letter
        self.count = count
        self.probl = probl


    def __repr__(self):
        return f"{self.Letter}:({self.count};{round(self.probl, 2)})"
    

    def __add__(self, other: "Letter") -> "Letter":
        """ Оператор  + """
        if(type(other) != Letter): raise TypeError()

        return Letter(
            self.Letter + other.Letter,
            self.count + other.count,
            self.probl + other.probl
        )


    def __lt__(self, value: "Letter") -> bool:
        """ Оператор  < """
        return self.probl < value.probl


    def __le__(self, value: "Letter") -> bool:
        """ Оператор  <= """
        return self.probl <= value.probl


    def __eq__(self, other):
        """ Оператор == """
        if(type(other) != Letter): return False
        if(self.Letter != other.Letter):  return False
        if(self.count != other.count):  return False
        if(self.probl != other.probl):  return False
        return True
    
    
    @staticmethod
    def Parse(text: str):
        """ Получение букв для нод из текста

        Args:
            text (str): Текст для парсинга

        Returns:
            dict[str, int]: Словарь с узлами
                str - название буквы
                int - вес буквы
        """
        text = text.lower()

        temp_dict = {}
        for i in text:
            if(i not in temp_dict):
                temp_dict[i] = 1
                continue
            temp_dict[i] += 1


        res = []

        for i in temp_dict:
            res.append(
                Letter(
                    i, temp_dict[i], temp_dict[i] / len(text)
                )
            )
            
        return res

