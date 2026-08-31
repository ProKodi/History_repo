



from .Letter import Letter


class HuffmanNode:
    """ Нода для дерева хафмана """

    def __init__(self, val: Letter, left: "HuffmanNode" = None, right: "HuffmanNode" = None):
        """ Создание ноды

        Args:
            val (Letter): Буква для ноды
        """
        self.val = val
        self.left = left
        self.right = right
        # Код символа
        self.code = ""


    def __repr__(self):
        """ Вывод узла в консоль
        """
        res = f"{self.val}" + "{" + self.code + "}\n"

        if(self.left != None):
            res += "|\n"
            left_str = self.left.__repr__().split("\n")
            res += f"|-(L)- {left_str.pop(0)}\n"

            for i in left_str:
                res += f"|\t {i}\n"

        if(self.right != None):
            res += "|\n"
            right_str = self.right.__repr__().split("\n")
            res += f"|-(R)- {right_str.pop(0)}\n"

            for i in right_str:
                res += f"|\t {i}\n"

        return res


    def __lt__(self, other: "HuffmanNode") -> bool: 
        """ Оператор  < """
        return self.val.__lt__(other.val)


    def __le__(self, other: "HuffmanNode") -> bool:
        """ Оператор  <= """
        return self.val.__le__(other.val)


    def __eq__(self, other: "HuffmanNode"):
        """ Оператор == """
        if(type(other) != HuffmanNode): return False
        return self.val.__le__(other.val)

