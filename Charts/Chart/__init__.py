



import matplotlib.pyplot as plt
from .ConverterType import *


def setAxles(title_x: str, title_y: str):
    """Устанавливаем название осям 
    Args:
        title_x (str): Название оси x
        title_y (str): Название оси y
    """
    plt.xlabel(title_x)
    plt.ylabel(title_y)


def setTitle(name: str):
    """Устанавливаем название графику 
    Args:
        name (str): Название графика
    """
    plt.title(name)
    
    
def buildChart(type_x:IArgs_X, function_y):
    """Построение графика
    Args:
        array_x (_type_): Список аргументов (х)
        function_y (_type_): Функция
    """
    args_x = type_x.to_float(); 
    plt.xticks(args_x, type_x.to_string())
    X = []
    Y = []
    
    for i in range(len(args_x) - 1):
        temp = args_x[i]
        while(True):
            if(temp > args_x[i+1]):
                break
            temp += 0.001
            X.append(temp)
            Y.append(function_y(temp))
    
    plt.plot(X, Y)
    plt.show()
