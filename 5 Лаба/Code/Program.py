



import math


if __name__ == "__main__":
    from Formulas import Formulas
    from Data import Data
    from NumberInDouble import NumberInDouble

else:
    from .Formulas import Formulas
    from .Data import Data
    from .NumberInDouble import NumberInDouble





        
    

def main():
    inputed_word = input("Введите комбинацию: ");
    dat_without_correct_bit = Data(inputed_word)
    print(f"Комбинация без корректирующего кода: {dat_without_correct_bit}")
    dat_with_correct_bit = Formulas.GetBitsOnPositions(
        dat_without_correct_bit
    )
    print(f"Комбинация c корректирующем кодом: {dat_with_correct_bit}")


    print("Тесты на ошибку")

    inputed_word = input("Введите комбинацию: ");
    dat_without_correct_bit = Data(inputed_word)
    print(f"Введенная комбинация для проверки: {dat_without_correct_bit}")
    eror_pos = Formulas.CheckTestingBits(dat_without_correct_bit)


    match (eror_pos):
        case 0:
            print("Ошибки нет или более одной ошибки")
        # case -1:
        #     print("Более 1 ошибки / разряда не существует") 
        case _:
            print(f"Номер  ошибочной  позиции: {eror_pos}");



    



if __name__ == "__main__":
    main()