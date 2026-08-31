



from math import cos, sin, pi
from Chart import *


def main():
    setAxles("wt", "I")
    setTitle("Временная диаграмма токов для резистивного элемента")
    
    buildChart(
        Degrees([i  for i in range(0, 361, 15)]), 
        lambda x: (0.06 * sin(x + (pi / 2)))
    )
    
    
    
    setAxles("wt", "U")
    setTitle("Временная диаграмма напряжений для резистивного элемента")
    
    buildChart(
        Degrees([i  for i in range(0, 361, 15)]), 
        lambda x: (45.82 * sin(x))
    )
    
    '''
    IL = 0.85 * sin(wt +  pi/2), UL = 45.68 * sin(wt)
    IC = 0.54 * sin(wt +  pi/2), UC = 45.96 * sin(wt)
    IR = 0.06 * sin(wt +  pi/2), UR = 45.82 * sin(wt)
    
    Временная диаграмма токов (это где I)/напряжений (это где U) 
        для индуктивного элемента (L)
        ёмкостного элемента (C)
        резистивного элемента (R)
    
    
    '''
    
    

if __name__ == "__main__":
    main()