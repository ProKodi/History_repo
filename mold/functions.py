



"""
Модуль содержит всякое

Классы:
------
    \t1) Laplas - Все что связано с Лаплассом(локальная теорема, функция, интегральная теорема)
    
Функции:
-------
    \t1) bernoul - Формула Бернули
    \t2) full_probability - Полная вероятность
    \t3) bayes - Формула Байса
    \t4) probab_deviation - Функция вероятности отклонения



"""




from .combinatorics import NotRepeat
from scipy import stats # pip install scipy
from math import pi, e


class Laplas:
    """Все что связано с Лаплассом"""
    
    @staticmethod
    def local_laplas(n: int, m: int, p: float, q: float) -> float:
        """Локальная теорема Лапласса

        Args:
            n (int): количество испытаний
            m (int): количество испытаний с нужным исходом
            p (float): вероятность нужного события
            q (float): вероятность не появления нужного события
        """
        x = (m - (n*p)) / ((n* p * q) ** 0.5)
        temp = e ** ((-(x ** 2)) / 2)
        temp /= (2 * pi) ** 0.5
        temp /= (n * p * q) ** 0.5
        return temp

    @staticmethod
    def F(x: float):
        """Функция Лаппласса"""
        return stats.norm.cdf(x) - 0.5
    
    @staticmethod
    def integrate_laplas(n: int, m1: int, m2: int, p: float, q: float) -> float:
        """Интегральная теорема Лапласса

        Args:
            n (int): количество испытаний
            m1 (int): количество испытаний с нужным исходом (1 случай)
            m2 (int): количество испытаний с нужным исходом (2 случай)
            p (float): вероятность нужного события
            q (float): вероятность не появления нужного события
        """
        x1 = (m1 - (n * p)) / ((n*p*q) ** 0.5)
        x2 = (m2 - (n * p)) / ((n*p*q) ** 0.5)
        return __class__.F(x2) -  __class__.F(x1)





def bernoul(n: int, m: int, p: float, q: float) -> float:
    """Формула Бернули

    Args:
        n (int): количество испытаний
        m (int): количество испытаний с нужным исходом
        p (float): вероятность нужного события
        q (float): вероятность не появления нужного события
    """
    return NotRepeat.c(n, m) * (p ** m) * (q ** (n - m))
    
    
    
def full_probability(lst: list[tuple[float, float]]) -> float:
    """Полная вероятность

    Args:
        lst (list[tuple[float, float]]): Список где каждый элемент это  вероятность события и его условная вероятность
    """
    res = 0
    for i in lst:
        res += i[0] * i[1]
        
    return res
    
    
    
def bayes(p1: float, pif1: float, full_prob: float):
    """Формула Байса

    Args:
        p1 (float): вероятность нужного события
        pif1 (float): условная вероятность нужного события
        full_prob (float): полная вероятность
    """
    return (p1 * pif1) / full_prob

    
def probab_deviation(n: int, p: float, q: float, E: float):
    """Функция вероятности отклонения

    Args:
        n (int): количество испытаний
        p (float): вероятность нужного события
        q (float): вероятность не появления нужного события
        E (float): Отклонение статистики от вероятности
    """
    x = (E * (n ** 0.5)) / ((p * q) ** 0.5)
    return 2 * Laplas.F(x)
    

    
    
    
    
    
def main():
    print(bernoul(10, 3, 0.5, 0.5))
    print(Laplas.local_laplas(400, 200, 0.5, 0.5))
    print(Laplas.F(6))
    print(Laplas.integrate_laplas(100, 65, 80, 0.7, 0.3))
    
    print(full_probability([(0.6, 0.95), (0.4, 0.7)]))
    print(
        bayes(0.4, 0.8, 
            full_probability([(0.4, 0.8), (0.6, 0.9)])
        )
    )
    
    print(probab_deviation(1000, 0.52, 0.48, 0.02))
    
    
if __name__ == "__main__":
    main()