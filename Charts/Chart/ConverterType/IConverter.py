



import abc

class IArgs_X(abc.ABC):
    """Интерфейс для аргументов"""
    values = []
    
    @abc.abstractmethod 
    def to_string(self) -> list[str]:
        """Конвертирование значений в строку""" 
    
    @abc.abstractmethod 
    def to_float(self) -> list[float]:
        """Конвертирование значений в число""" 