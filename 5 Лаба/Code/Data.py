



from typing import SupportsIndex


class Data:
    """ Класс для работы с данными """

    def __init__(self, dat_str: str):
        """ Инициализатор

        Args:
            dat_str (str): Строка с данными
        """
        
        
        for i in dat_str:
            if(i not in ("1", "0")):
                raise ValueError("Подана не верная строка")
        
        self.__dt = [i == "1" for i in dat_str]
        

    def __getitem__(self, i: SupportsIndex) -> bool: 
        """ Оператор self[i]

        Args:
            i (SupportsIndex): Индекс элемента

        Returns:
            str: Элемент
        """
        return self.__dt[i]


    def __setitem__(self, i: SupportsIndex, value:bool) -> None:
        """ Оператор self[i] = value

        Args:
            i (SupportsIndex): Индекс элемента
            value: Данные для вставки

        Returns:
            str: Элемент
        """
        if(value is not bool()):
            raise ValueError("Подана не верные данные")
        
        self.__dt[i] = bool(value)


    def __len__(self) -> int:  return len(self.__dt)


    def __repr__(self) -> str:  return "".join(["1" if i else "0" for i in self.__dt] )


    def __eq__(self, value: object) -> bool:
        """ Оператор == """
        return ( 
            (type(value) == Data) and
            (value.__dt == self.__dt)
        )