



import unittest
import sys
import os

# Возращаем интерпретатор в корневую папку
sys.path.append(
    os.path.abspath(
        os.path.join(os.path.dirname(__file__), '..')
    )
)


# Импортируем программу
from Code.Program import *



# Класс тестов — наследуется от unittest.TestCase
class TestFunction(unittest.TestCase):

    '''def testData(self):
        """ Тестирование типа данных Data """
        test = Data("0101")
        self.assertEqual(test._Data__dt, [False, True, False, True])
        self.assertEqual(test[0], False)
        self.assertEqual(test[1], True)
        self.assertEqual(test[2], False)
        self.assertEqual(test[3], True)


        test = Data("1101")
        self.assertEqual(test._Data__dt, [True, True, False, True])

        self.assertRaises(ValueError, test.__setitem__, 0, 9)
        
        test[0] = False;
        self.assertEqual(test[0], False)
        
        self.assertEqual(test.__len__(), 4)
        self.assertEqual(test.__repr__(), '0101')



    def testGetTestingBit(self):
        """ Тестирование определения количества проверочных битов """
        # Тест не определеного поведения (по идее подавать m = 0 - запрещено)
        self.assertEqual(0, Formulas.GetTestingBit(0))

        self.assertEqual(2, Formulas.GetTestingBit(1))
        self.assertEqual(3, Formulas.GetTestingBit(2))
        self.assertEqual(3, Formulas.GetTestingBit(4))
        self.assertEqual(4, Formulas.GetTestingBit(5))
        self.assertEqual(4, Formulas.GetTestingBit(11))
        self.assertEqual(5, Formulas.GetTestingBit(12))
        
    def testGetPowerTwo(self):
        """ Тестирование определения количества проверочных битов """
        # Тест получения степени по основанию 2
        self.assertEqual(0, Formulas.GetTestingBit(0))

        self.assertEqual( Formulas.GetPowerTwo(1), (0.0, True) )
        self.assertEqual( Formulas.GetPowerTwo(2), (1.0, True) )
        self.assertEqual( Formulas.GetPowerTwo(4), (2.0, True) )
        self.assertEqual( Formulas.GetPowerTwo(8), (3.0, True) )

        self.assertEqual( Formulas.GetPowerTwo(3)[1], False )
        self.assertEqual( Formulas.GetPowerTwo(5)[1], False )
        self.assertEqual( Formulas.GetPowerTwo(6)[1], False )
        self.assertEqual( Formulas.GetPowerTwo(7)[1], False )


    def testGetPowerTwo(self):
        """ Тестирование определения количества проверочных битов """
        # Тест получения степени по основанию 2
        self.assertEqual(0, Formulas.GetTestingBit(0))

        self.assertEqual( Formulas.GetPowerTwo(1), (0.0, True) )
        self.assertEqual( Formulas.GetPowerTwo(2), (1.0, True) )
        self.assertEqual( Formulas.GetPowerTwo(4), (2.0, True) )
        self.assertEqual( Formulas.GetPowerTwo(8), (3.0, True) )

        self.assertEqual( Formulas.GetPowerTwo(3)[1], False )
        self.assertEqual( Formulas.GetPowerTwo(5)[1], False )
        self.assertEqual( Formulas.GetPowerTwo(6)[1], False )
        self.assertEqual( Formulas.GetPowerTwo(7)[1], False )


    def testNumberInDouble(self):
        """ Тестирование числа в двоичной форме """
        my_num = NumberInDouble(4)
        self.assertEqual(str(my_num), "100")
        self.assertEqual(my_num[0], False)
        self.assertEqual(my_num[1], False)
        self.assertEqual(my_num[2], True)

        # Выход за границы
        self.assertEqual(my_num[3], False)


    def testGetBitsOnPositions(self):
        """ Тестирование размещения битов по позициям """
        
        test = Data("0101")
        dt_correct = Data("0100101")
        self.assertEqual(Formulas.GetBitsOnPositions(test), dt_correct)

        test = Data("")
        dt_correct = Data("")
        self.assertEqual(Formulas.GetBitsOnPositions(test), dt_correct)


    def testCheckTestingBits(self):
        """ Тестирование проверки слова по корректирующим битам """
        
        test = Data("0100101")
        self.assertEqual(Formulas.CheckTestingBits(test), 0)
        
        test = Data("0110011")
        self.assertEqual(Formulas.CheckTestingBits(test), 0)

        test = Data("0100111")
        self.assertEqual(Formulas.CheckTestingBits(test), 6)

        test = Data("0111001")
        self.assertEqual(Formulas.CheckTestingBits(test), 2)  

    '''
        







if __name__ == "__main__":  unittest.main()