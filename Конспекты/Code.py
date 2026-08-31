



import math


def Hmax(cnt_leters: int) -> float:
    """Макс. энтропия

    Args:
        cnt_leters (int): Кол-во букв в алфавите
    """
    return math.log2(cnt_leters)



def H(prb_leters: list[float]) -> float:
    """ Энтропия общая

    Args:
        prb_leters (list):  Список с вероятностями для рассчета энтропии
    """

    return -sum(
        [i * math.log2(i) for i in prb_leters]
    )
    
