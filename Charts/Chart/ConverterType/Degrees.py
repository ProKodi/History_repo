



from math import pi
from .IConverter import IArgs_X


class Degrees(IArgs_X):
    """Градусы"""
    def __init__(self, values: list[int]):
        self.values = values
        
        
    def to_string(self) -> list[str]:
        """Конвертирование значений в строку""" 
        return [f"{str(i)}°" for i in self.values]
        
    def to_float(self) -> list[float]:
        """Конвертирование значений в число""" 
        return [((i * pi)/180) for i in self.values]
