



from typing import SupportsIndex


class NumberInDouble:
    """ Представление числа в двоичной форме """

    def __init__(self, number: int):
        """
        Args:
            number (int): Число для представаления в двоичной форме
        """
        self.__numbers = [i == "1" for i in f"{number:b}"]

    def __getitem__(self, i: SupportsIndex) -> bool: 
        """ Оператор self[i]

        Args:
            i (SupportsIndex): Индекс элемента

        Returns:
            str: Элемент
        """
        try:  return self.__numbers[-(i + 1)]
        except IndexError:  return False; 


    def __repr__(self):
        return "".join(["1" if i else "0" for  i in self.__numbers])