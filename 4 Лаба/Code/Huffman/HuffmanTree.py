



from .HuffmanNode import HuffmanNode
from .Letter import Letter



class HuffmanTree:
    """ Дерево хафмана """

    def __init__(self, nodes: list[Letter]):
        if(len(nodes) < 1):
            raise ValueError("Подан пустой список нод")
        
        nodes: list[HuffmanNode] = [
            HuffmanNode(i) for i in nodes
        ]
        nodes.sort(reverse=True)

        self.list_Leters = nodes[:]
        
        while (len(nodes) > 1):
            right = nodes.pop()
            left = nodes.pop()

            nodes.append(HuffmanNode(
                right.val + left.val, left, right
            ))
            nodes.sort(reverse=True)

        self.root_node = nodes[0]
        __class__.__build_code(self.root_node)

    @staticmethod
    def __build_code(curent_node: HuffmanNode, code_for_node:str = ""):
        """ Постройка кодов для нод дерева """
        if(curent_node == None): return 

        curent_node.code = code_for_node;

        if(curent_node.left != None):
            __class__.__build_code(curent_node.left, code_for_node + "0")
        
        if(curent_node.right != None):
            __class__.__build_code(curent_node.right, code_for_node + "1")


    def __eq__(self, other: "HuffmanTree"):
        """ Оператор == """
        if(type(other) != HuffmanTree): return False
        return self.root_node.__le__(other.root_node)



    def __repr__(self):
        """ Вывод в консоль """
        return self.root_node.__repr__();


    def get_table(self):
        """ Вывод таблицы """
        res = []

        nodes: list[HuffmanNode] = self.list_Leters[:]
        nodes.sort(reverse=True)

        res.append(
            [i.val.Letter for i in nodes]
        )

        while (len(nodes) > 1):
            res.append(
                [i.val.probl for i in nodes]
            )

            right = nodes.pop()
            left = nodes.pop()

            nodes.append(HuffmanNode(
                right.val + left.val, left, right
            ))
            nodes.sort(reverse=True)

        res.append(
            [i.val.probl for i in nodes]
        )


        table = f"{'Знаки': ^8}|{'Вероятности': ^15}| Вспомогательные столбцы\n"

        trings = []

        while len(res) > 0:
            temp = []
            for i in res:
                if(len(i) <= 0): continue

                temp.append(i.pop(0))

            trings.append(temp)


            temp = []

            for i in res:
                if(len(i) <= 0): continue
                temp.append(i)

            res = temp


        for i in trings:
            table += f"{i[0]: ^8}|{str(round(i[1], 2)): ^15}| {"\t".join( [str(round(ii, 2)) for ii in i[2:]] )}\n"


        return table