



import math


if __name__ == "__main__":
    from Huffman import Letter, HuffmanTree, HuffmanNode
    from Formulas import Formulas
else:
    from .Huffman import Letter, HuffmanTree, HuffmanNode
    from .Formulas import Formulas




        
    

def main():
    leters = Letter.Parse(
        input("Введите кодируемое слово:")
    )
    tree = HuffmanTree(leters)

    temp = []

    def get_leters(select_node):
        flag = True
        if(select_node.left != None):
            get_leters(select_node.left)
            flag = False

        if(select_node.right != None):
            get_leters(select_node.right)
            flag = False

        if(flag):
            temp.append(select_node)
            

    get_leters(tree.root_node)

        
    
    koe = Formulas.Koe(
        Formulas.H(temp),
        Formulas.L(temp)
    )


    print("Дерево Хаффмана:")
    print(tree)

    print(f"Коэффициент относительной эффективности {round(koe, 2)}")

    print("Таблица:")
    print(tree.get_table())




if __name__ == "__main__":
    main()