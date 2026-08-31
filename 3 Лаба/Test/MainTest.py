



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


Data = [
    Letter("A1", 1/4, "00"),
    Letter("A2", 1/4, "01"),

    Letter("A3", 1/8, "100"),
    Letter("A4", 1/8, "101"),

    Letter("A5", 1/16, "1100"),
    Letter("A6", 1/16, "1101"),
    Letter("A7", 1/16, "1110"),
    Letter("A8", 1/16, "1111")
]

# Класс тестов — наследуется от unittest.TestCase
class TestFunction(unittest.TestCase):
    def testH(self):
        self.assertEqual(2.75, Formulas.H(Data))

    def testL(self):
        self.assertEqual(2.75, Formulas.L(Data))

    def testParseText(self):
        res = Letter.ParseText("Теестт");
        correct = [
            Letter("т", 1/2, "0"),
            Letter("е", 1/3, "10"),
            Letter("с", 1/6, "11")
        ]

        self.assertEqual(correct, res)

        res = Letter.ParseText("Кодирование");
        correct = [
            Letter("о", 2/11, "000"),
            Letter("и", 2/11, "001"),
            Letter("к", 1/11, "010"),
            Letter("д", 1/11, "011"),
            Letter("р", 1/11, "1000"),
            Letter("в", 1/11, "1001"),
            Letter("а", 1/11, "101"),
            Letter("н", 1/11, "110"),
            Letter("е", 1/11, "111")
        ]
        self.assertEqual(correct, res)
        







# from Test.TestFunction import *
# from Test.TestPerson import *



if __name__ == "__main__":  unittest.main()