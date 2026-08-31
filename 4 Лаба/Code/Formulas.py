



import math


if __name__ == "Formulas":
    from Huffman.HuffmanNode import HuffmanNode
else:
    from .Huffman.HuffmanNode import HuffmanNode


class Formulas:
    """ Класс для работы с формулами """

    @staticmethod
    def H(arg: list[HuffmanNode]) -> float:
        """ Энтропия

        Args:
            arg (list[Letter]): список с буквами 
                (если вероятности одинаковы то свернется просто до логарифма и будет макс энтропией)
            
        """
        res = 0;

        for pi in [lett.val.probl for lett in arg]:  res += pi * math.log2(pi)
        res = -res

        return res
    

    @staticmethod
    def L(Letter: list[HuffmanNode]) -> float:
        """ Среднее число двоичных знаков на букву кода

        Args:
            Letter (list[Letter]): список с буквами 
        """
        res = 0;

        for lett in Letter:  
            res += len(lett.code) * lett.val.probl

        return res

    
    @staticmethod
    def Kcc(Hmax: float, Lcp: float):
        """ Коэфиицент статического сжатия 

        Args:
            H (float): Энтропия максимальная
            Lcp (float): Среднее число двоичных знаков на букву кода
        """
        return Hmax / Lcp
    

    @staticmethod
    def Koe(H: float, Lcp: float):
        """ Коэффициент  относительной эффективности

        Args:
            H (float): Энтропия
            Lcp (float): Среднее число двоичных знаков на букву кода
        """
        return H / Lcp
    



"""
N - количество символов в начальном алфавите
m - количество символов в конечном
l(i) - длина закодированного символа
p(i) - вероятность появления закодированного сообщения
L ср - средняя длина сообщения
H max - макс. энтропия - по формуле энтропии находим 
        
"""
