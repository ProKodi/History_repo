



"""
Тесты для программы systematic_linear_code.py
"""

from systematic_linear_code import (
    calculate_information_bits,
    calculate_control_bits,
    create_identity_matrix,
    create_check_matrix,
    create_generator_matrix,
    create_control_matrix,
    encode,
    add_error,
    calculate_syndrome,
    find_error_position,
    correct_error
)


# ============================================================
# ТЕСТ 1
# Проверка вычисления числа информационных разрядов
# ============================================================

def test_information_bits():

    assert calculate_information_bits(16) == 4
    assert calculate_information_bits(8) == 3
    assert calculate_information_bits(32) == 5

    print("Тест 1 пройден")


# ============================================================
# ТЕСТ 2
# Проверка вычисления числа контрольных разрядов
# ============================================================

def test_control_bits():

    assert calculate_control_bits(4) == 3
    assert calculate_control_bits(3) == 3
    assert calculate_control_bits(5) == 4

    print("Тест 2 пройден")


# ============================================================
# ТЕСТ 3
# Проверка единичной матрицы
# ============================================================

def test_identity_matrix():

    matrix = create_identity_matrix(4)

    expected = [
        [1, 0, 0, 0],
        [0, 1, 0, 0],
        [0, 0, 1, 0],
        [0, 0, 0, 1]
    ]

    assert matrix == expected

    print("Тест 3 пройден")


# ============================================================
# ТЕСТ 4
# Проверка построения порождающей матрицы
# ============================================================

def test_generator_matrix():

    I = create_identity_matrix(4)
    P = create_check_matrix()

    C = create_generator_matrix(I, P)

    expected = [
        [1, 0, 0, 0, 0, 1, 1],
        [0, 1, 0, 0, 1, 0, 1],
        [0, 0, 1, 0, 1, 1, 0],
        [0, 0, 0, 1, 1, 1, 1]
    ]

    assert C == expected

    print("Тест 4 пройден")


# ============================================================
# ТЕСТ 5
# Проверка кодирования
# ============================================================

def test_encoding():

    I = create_identity_matrix(4)
    P = create_check_matrix()
    C = create_generator_matrix(I, P)

    message = [1, 0, 1, 1]

    encoded = encode(message, C)

    expected = [1, 0, 1, 1, 0, 1, 0]

    assert encoded == expected

    print("Тест 5 пройден")


# ============================================================
# ТЕСТ 6
# Проверка внесения ошибки
# ============================================================

def test_add_error():

    codeword = [1, 0, 1, 1, 0, 1, 0]

    corrupted = add_error(codeword, 2)

    expected = [1, 0, 0, 1, 0, 1, 0]

    assert corrupted == expected

    print("Тест 6 пройден")


# ============================================================
# ТЕСТ 7
# Проверка вычисления синдрома
# ============================================================

def test_syndrome():

    I = create_identity_matrix(4)
    P = create_check_matrix()

    H = create_control_matrix(P, 3)

    received = [1, 0, 0, 1, 0, 1, 0]

    syndrome = calculate_syndrome(received, H)

    expected = [1, 1, 0]

    assert syndrome == expected

    print("Тест 7 пройден")


# ============================================================
# ТЕСТ 8
# Проверка определения позиции ошибки
# ============================================================

def test_error_position():

    I = create_identity_matrix(4)
    P = create_check_matrix()

    H = create_control_matrix(P, 3)

    syndrome = [1, 1, 0]

    position = find_error_position(syndrome, H)

    expected = 2

    assert position == expected

    print("Тест 8 пройден")


# ============================================================
# ТЕСТ 9
# Проверка исправления ошибки
# ============================================================

def test_error_correction():

    received = [1, 0, 0, 1, 0, 1, 0]

    corrected = correct_error(received, 2)

    expected = [1, 0, 1, 1, 0, 1, 0]

    assert corrected == expected

    print("Тест 9 пройден")


# ============================================================
# ТЕСТ 10
# Полный цикл кодирования и декодирования
# ============================================================

def test_full_cycle():

    # Матрицы
    I = create_identity_matrix(4)
    P = create_check_matrix()

    C = create_generator_matrix(I, P)
    H = create_control_matrix(P, 3)

    # Исходное сообщение
    message = [1, 0, 1, 1]

    # Кодирование
    encoded = encode(message, C)

    # Ошибка
    corrupted = add_error(encoded, 2)

    # Синдром
    syndrome = calculate_syndrome(corrupted, H)

    # Поиск ошибки
    position = find_error_position(syndrome, H)

    # Исправление
    corrected = correct_error(corrupted, position)

    # Проверка
    assert corrected == encoded

    print("Тест 10 пройден")


# ============================================================
# Запуск всех тестов
# ============================================================

if __name__ == "__main__":

    print("=" * 50)
    print("ЗАПУСК ТЕСТОВ")
    print("=" * 50)

    test_information_bits()
    test_control_bits()
    test_identity_matrix()
    test_generator_matrix()
    test_encoding()
    test_add_error()
    test_syndrome()
    test_error_position()
    test_error_correction()
    test_full_cycle()

    print("\nВсе тесты успешно пройдены.")