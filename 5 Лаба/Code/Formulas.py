



import math
from Data import Data
from NumberInDouble import NumberInDouble


class Formulas:
    """ Формулы для рассчета """


    @staticmethod
    def GetTestingBit(m: int) -> int:
        """ Определить количество проверочных битов

        Args:
            m (int): длина данных
        Returns:
            int: число проверочных битов
        """

        r = 0;

        while True:
            if((2 ** r) >= (m + r + 1)):
                return r
            
            r += 1


    @staticmethod
    def GetPowerTwo(num: int) -> tuple[float, bool]:
        """ Получение степени по основанию 2

        Args:
            num (int): Число для проверки

        Returns:
            float: Степень по основанию 2
            bool: false если число не является степенью 2
        """
        step = math.log2(num)
        return ( step, step == int(step) )
    

    @staticmethod
    def GetBitsOnPositions(dat: Data) -> Data:
        """ Построение слова с коректирующими битами

        Args:
            dat (Data): Данные для размещения

        Returns:
            list: слово с проверочными битами
        """
        # Длина нового слова:
        n = len(dat) + __class__.GetTestingBit(len(dat))

        res = []
        i = 0;
        # Устанавливаем проверяющие биты на свое место (пока это P)
        for p in range(1, n + 1):
            if( __class__.GetPowerTwo(p)[1] ):
                res.append("P")
                continue

            res.append(dat[i])
            i += 1

        i = 0;
        # Определяем значения для P
        for ii in range(n):
            if(res[ii] != "P"):  continue

            tmp = []
            # Идем по массиву натуральных чисел (максимальное нат число - размерность нового слова) 
            for num in range(1, n + 1):
                # Игнорируем искомый символ
                if((num - 1) == ii): continue 
                num_temp = NumberInDouble(num)
                if(not num_temp[i]): continue
                # Если нужный нам бит - 1, то берем число
                tmp.append(num - 1)

            # По найденым числам, вытаскиваем биты из формируемого слова
            tmp = [int(res[iii]) for iii in tmp]
            res[ii] = sum(tmp) % 2 != 0

            i += 1

        return Data("".join(["1" if i else "0" for i in res]))
    

    @staticmethod
    def CheckTestingBits(dat: Data) -> int:
        """ Проверка слова по корректирующим битам

        Args:
            dat (Data): Слово для проверки

        Returns:
            int: разряд в котором случилась ошибка (0 если ошибки нет, -1 если ошибок более чем 1)
        """
        i = 0
        res = []
        for ii in range(len(dat)):
            if(not __class__.GetPowerTwo(ii+1)[1]): continue

            tmp = []
            for num in range(1, len(dat) + 1):
                num_temp = NumberInDouble(num)
                if(not num_temp[i]): continue
                # Если нужный нам бит - 1, то берем число
                tmp.append(num - 1)
            
            # По найденым числам, вытаскиваем биты из формируемого слова
            tmp = [int(dat[iii]) for iii in tmp]
            
            res.append( sum(tmp) % 2 != 0 )
            i += 1

        res.reverse()

        res = "".join([str(int(i)) for i in res])
        res = int(res, 2)

        if(res > len(dat)):
            res = -1

        return res
            

            
            






        
            
        


        
        
        
