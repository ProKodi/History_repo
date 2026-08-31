



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

    def testGetNodes(self):
        text = "Mothermrr"
        res = [
            Letter('m', 2, 2 / len(text)),
            Letter('o', 1, 1 / len(text)),
            Letter('t', 1, 1 / len(text)),
            Letter('h', 1, 1 / len(text)),
            Letter('e', 1, 1 / len(text)),
            Letter('r', 3, 3 / len(text))

        ]
        self.assertEqual(res, Letter.Parse(text))

    def testHuffmanTree(self):
        text = "abracadabra"
        res = Letter.Parse(text)

        temp = HuffmanTree(res)

        correct = HuffmanTree(res)
        correct.root_node = HuffmanNode( val = Letter("abdcr", 11, 11 / 11),

            left = HuffmanNode( val = Letter("bdcr", 6, 6 / 11),

                left = HuffmanNode( val = Letter("dcr", 4, 4 / 11),
                    left = HuffmanNode( val = Letter("r", 2, 2 / 11), ),

                    right = HuffmanNode( val = Letter("dc", 2, 2 / 11),
                        left= HuffmanNode( val = Letter("c", 1, 1 / 11)),
                        right= HuffmanNode( val = Letter("d", 1, 1 / 11))            
                    )
                ),
                right = HuffmanNode( val = Letter("b", 2, 2 / 11) )
            ),
            right = HuffmanNode( val = Letter("a", 5, 5 / 11) )
        )
        HuffmanTree._HuffmanTree__build_code(correct.root_node)

        self.assertEqual(correct, temp)

        # print()
        # print(temp)
        # print(str(temp))


    def testTable(self):
        text = "abracadabra"
        res = Letter.Parse(text)

        temp = HuffmanTree(res)

        temp.get_table()


    






if __name__ == "__main__":  unittest.main()