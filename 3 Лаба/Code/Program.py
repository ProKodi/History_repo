



import math


if __name__ == "__main__":
    from Letter import Letter
    from Formulas import Formulas
else:
    from .Letter import Letter
    from .Formulas import Formulas




        
    





def main():
    text = input("Введи то что хотите закодировать:")
    list_letters = Letter.ParseText(text)


    max_col_size = []

    temp = max([len(i.let) for i in list_letters])
    max_col_size.append( temp if temp > len('Буква') else len('Буква') )

    temp = max([len(str(round(i.prb, 2))) for i in list_letters])
    max_col_size.append( temp if temp > len('Вероятность') else len('Вероятность') )

    temp = max([len(i.code) for i in list_letters])
    max_col_size.append( temp if temp > len('Кодовое слово') else len('Кодовое слово') )

    temp = len(str(max_col_size[2]))
    max_col_size.append( temp if temp > len('Число знаков') else len('Число знаков') )

    print(
        f"{'Буква': ^{max_col_size[0]}}|{'Вероятность': ^{max_col_size[1]}}|{'Кодовое слово': ^{max_col_size[2]}}|{'Число знаков': ^{max_col_size[3]}}|{'L(i)pi': ^8}"
    )

    for i in list_letters:
        print(
            f"{i.let.upper(): ^{max_col_size[0]}}|{round(i.prb, 2): ^{max_col_size[1]}}|{i.code: <{max_col_size[2]}}|{len(i): ^{max_col_size[3]}}|{round(i.prb*len(i), 2): ^8}"
        )

    """kcc = Formulas.Kcc(
        Formulas.H(list_letters),
        Formulas.L(list_letters)
    )
    print(f"Коэфиицент статического сжатия {kcc}")"""

    koe = Formulas.Koe(
        Formulas.H(list_letters),
        Formulas.L(list_letters)
    )
    print(f"Коэффициент относительной эффективности {round(koe, 2)}")






if __name__ == "__main__":
    main()