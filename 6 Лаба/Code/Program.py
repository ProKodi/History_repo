



if __name__ == "__main__":
    from Modl import LinearSystematicCode

else:
    from .Modl import LinearSystematicCode

import numpy as np




# ==============================================================
# MAIN
# ==============================================================

if __name__ == "__main__":
    N = int(input("Введите количество букв в первичном алфавите N: "))


    # СОЗДАНИЕ КОДА
    code = LinearSystematicCode(N) # 16

    # ВЫВОД ПАРАМЕТРОВ
    code.print_info()

    # ВЫВОД МАТРИЦ
    code.print_matrices()


    print("Представим что вы ввели следующее исходное сообщение: ")
    # Случайное сообщение
    data = code.random_message()
    print(data)


    print("Закодированное сообщение: ")
    # Кодирование
    encoded = code.encode(data)
    print(encoded)


    print("Представим что вы ввели следующее сообщение с ошибкой: ")
    corrupted, real_error = code.add_error(encoded)
    print(corrupted)
    # print(f"\nОшибка внесена в бит: {real_error}")


    print("Список проверок: ")
    temp = []
    for i in range(len(code.P[0])):
        temp.append([])


    for i in code.P:
        for ii in range(len(i)):
            temp[ii].append(i[ii])

    for i in range(len(temp)):
        print(f"P{i+1} (+) " + " (+) ".join([f"a{ii+1}" for ii in range(len(temp[i])) if temp[i][ii] == 1 ]) + f" = S{i+1}" )

    print()

    

    print("Синдром:")
    # Синдром
    syndrome = code.syndrome(corrupted)
    print(syndrome)




    print("Найденная ошибка:")
    # Исправление
    corrected, syndrome, found_error = code.correct(corrupted)
    print(found_error)

    print("Исправленное сообщение:")
    print(corrected)

    # Проверка
    success = np.array_equal(encoded, corrected)

    print("\nРезультат:")
    print(
        "Ошибка исправлена"
        if success
        else "Ошибка НЕ исправлена"
    )
