



"""
Модуль отвечающий за комбинаторику

Классы:
------
    \t1) NotRepeat - Формулы комбинаторки без повторений
    \t2) Repeat - Формулы комбинаторки с повторениями

"""


from math import factorial



class NotRepeat:
    """Формулы комбинаторки без повторений"""
    @staticmethod
    def p(n: int) -> int:
        """Перестановки"""
        return factorial(n) 
    
    @staticmethod
    def c(n: int, m: int) -> int:
        """Сочетания

        Args:
            n (int): количество объектов
            m (int): количество выбраных объектов
        """
        if(m > n):
            raise ValueError("Количество объектов меньше количества выбраных объектов")
        
        temp = n - m; 
        
        return factorial(n) / (factorial(temp) * factorial(m))
    
    @staticmethod
    def a(n: int, m: int) -> int:
        """Размещение

        Args:
            n (int): количество объектов
            m (int): количество выбраных объектов
        """
        if(m > n):
            raise ValueError("Количество объектов меньше количества выбраных объектов")
        
        return __class__.c(n, m) * __class__.p(m)
    
    
    
class Repeat:
    """Формулы комбинаторки с повторениями"""
    @staticmethod
    def p(n: int, list_repeat: list[int]) -> int:
        """Перестановки

        Args:
            n (int): количество объектов
            list_repeat (list[int]): количество повторений объектов
        """
        cout_repeat  = 1
        for i in list_repeat:
            cout_repeat *= factorial(i)
        
        return factorial(n) / cout_repeat
        
    @staticmethod
    def c(n: int, m: int) -> int:
        """Сочетания

        Args:
            n (int): количество объектов
            m (int): количество выбраных объектов
        """
        n += m - 1; 
        
        return NotRepeat.c(n, m)
    
    @staticmethod
    def a(n: int, m: int) -> int:
        """Размещение

        Args:
            n (int): количество объектов
            m (int): количество выбраных объектов
        """
        return n ** m
    
    
    
    
def main():
    print(NotRepeat.p(5) == 120)
    print(NotRepeat.c(5, 3) == 10)
    print(NotRepeat.a(5, 3) == 60)
    print(Repeat.p(11, [3, 3, 2, 1, 1, 1]) == 554_400)
    print(Repeat.c(3, 5) == 21)
    print(Repeat.a(10, 4) == 10_000)
    
    
    
if __name__ == "__main__":
    main()